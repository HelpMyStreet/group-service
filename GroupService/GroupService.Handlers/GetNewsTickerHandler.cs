using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts;
using HelpMyStreet.Utils.Models;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class GetNewsTickerHandler : IRequestHandler<NewsTickerRequest, NewsTickerResponse>
    {
        private readonly IRepository _repository;

        public GetNewsTickerHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<NewsTickerResponse> Handle(NewsTickerRequest request, CancellationToken cancellationToken)
        {
            NewsTickerResponse response = new NewsTickerResponse()
            {
                Messages = new List<NewsTickerMessage>()
            };

            List<int> groups = new List<int>();

            if (request.GroupId.HasValue)
            {
                groups.Add(request.GroupId.Value);
                var childGroups = _repository.GetChildGroups(request.GroupId.Value,cancellationToken);
                groups.AddRange(childGroups.Select(sm => sm.GroupId));
            }

            int volunteerCount = await _repository.MemberVolunterCount(groups);
            int newVolunteerCountInLast7Days = await _repository.MemberVolunterCountLastXDays(groups, 7);
            int newVolunteerCountInLastDay = await _repository.MemberVolunterCountLastXDays(groups, 1);

            if(volunteerCount>=5)
            {
                response.Messages.Add(new NewsTickerMessage()
                {
                    Value = volunteerCount,
                    Message = $"**{volunteerCount:n0}** volunteers waiting to help"
                });
            }

            if (newVolunteerCountInLast7Days >= 2 && newVolunteerCountInLastDay<=1)
            {
                response.Messages.Add(new NewsTickerMessage()
                {
                    Value = newVolunteerCountInLast7Days,
                    Message = $"**{newVolunteerCountInLast7Days:n0}** new volunteers joined this week"
                });
            }

            if (newVolunteerCountInLastDay >1)
            {
                response.Messages.Add(new NewsTickerMessage()
                {
                    Value = newVolunteerCountInLastDay,
                    Message = $"**{newVolunteerCountInLastDay:n0}** new volunteers joined today"
                });
            }

            return response;
        }
    }
}
