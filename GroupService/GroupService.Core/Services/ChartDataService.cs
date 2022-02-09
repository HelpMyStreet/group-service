using GroupService.Core.Domains;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.ReportService;
using HelpMyStreet.Utils.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Core.Services
{
    public class ChartDataService : IChartDataService
    {
        private readonly IRepository _repository;

        public ChartDataService(IRepository repository)
        {
            _repository = repository;
        }

        private async Task<List<int>> GetGroups(int groupId)
        {
            List<int> groups = new List<int>()
            {
                groupId
            };

            List<Group> childGroups = _repository.GetChildGroups(groupId, CancellationToken.None);
            groups.AddRange(childGroups.Select(sm => sm.GroupId));

            return groups;
        }

        private bool HasAdminAndMemberRole(List<UserRoleSummary> roleSummaries, int userId, DateTime dt)
        {
            IEnumerable<bool> roles = roleSummaries.Where(x => x.UserId == userId && x.DateRequested.Date == dt).Select(x=> x.IsAdmin).Distinct();

            return roles.Contains(true) && roles.Contains(false);            
        }

        public async Task<List<DataPoint>> GetVolumeByUserType(int groupId, DateTime minDate, DateTime maxDate)
        {
            var groups = await GetGroups(groupId);
            List<UserRoleSummary> roleSummary = await _repository.GetUserRoleSummary(groups, minDate, maxDate);

            List<UserRoleSummary> rolesToRemove = new List<UserRoleSummary>();

            roleSummary.Where(x => HasAdminAndMemberRole(roleSummary, x.UserId, x.DateRequested.Date) == true)
                .ToList()
                .ForEach(item =>
                {
                    var nonAdminRoles = roleSummary.Where(x => x.IsAdmin == false && x.UserId == item.UserId && x.DateRequested.Date == item.DateRequested.Date);
                    rolesToRemove.AddRange(nonAdminRoles);
                });            

            roleSummary = roleSummary.Except(rolesToRemove).ToList();

            List<(string roleType, bool isAdmin)> roleType = new List<(string roleType, bool isAdmin)>();
            roleType.Add(("Admins", true));
            roleType.Add(("Volunteers", false));

            List<DataPoint> dataPoints = PopulateListWithDefaultValues(minDate, maxDate, roleType.Select(x=> x.roleType).ToList());

            GroupAndReplaceValuesForKnown(
               dataPoints,
               roleSummary.GroupBy(x => new { Series = x.IsAdmin ? "Admins" : "Volunteers", x.DateRequested, x.UserId})
               .Select(x => new DataItem()
               {
                   Date = x.Key.DateRequested,
                   Series = x.Key.Series
               }).ToList());

            return dataPoints;
        }

        private void GroupAndReplaceValuesForKnown(List<DataPoint> dataPoints, List<DataItem> dataItems)
        {
            var groupedChartItems = dataItems.GroupBy(g => new { g.Series, date = $"{g.Date:yyyy}-{g.Date:MM}" })
                    .Select(s => new DataPoint
                    {
                        Value = s.Count(),
                        Series = s.Key.Series,
                        XAxis = s.Key.date
                    });

            //override chart items with actual values form the dataset.
            dataPoints.ForEach(item =>
            {
                var matchedItem = groupedChartItems.FirstOrDefault(x => x.XAxis == item.XAxis && x.Series == item.Series);

                if (matchedItem != null)
                {
                    item.Value = matchedItem.Value;
                }
            });
        }

        private List<DataPoint> PopulateListWithDefaultValues(DateTime minDate, DateTime maxDate, IEnumerable<string> series)
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            while (minDate <= maxDate)
            {
                series.ToList().ForEach(sa =>
                {
                    dataPoints.Add(new DataPoint() { Value = 0, XAxis = $"{minDate:yyyy}-{minDate:MM}", Series = sa });
                });
                minDate = minDate.AddMonths(1);
            }

            return dataPoints;
        }
    }
}
