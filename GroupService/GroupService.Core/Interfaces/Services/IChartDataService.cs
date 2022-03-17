using GroupService.Core.Domains;
using HelpMyStreet.Contracts.ReportService;
using HelpMyStreet.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface IChartDataService
    {
        Task<List<DataPoint>> GetVolumeByUserType(GroupAction action, int groupId, DateTime minDate, DateTime maxDate);
        Task<List<DataPoint>> TotalGroupUsersByType(int groupId);
    }
}
