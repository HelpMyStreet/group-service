using GroupService.Core.Domains;
using HelpMyStreet.Contracts.ReportService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GroupService.Core.Interfaces.Services
{
    public interface IChartDataService
    {
        Task<List<DataPoint>> GetVolumeByUserType(int groupId, DateTime minDate, DateTime maxDate);
        Task<List<DataPoint>> TotalGroupUsersByType(int groupId);
    }
}
