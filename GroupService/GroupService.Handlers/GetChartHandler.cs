using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.ReportService;
using HelpMyStreet.Contracts.ReportService.Request;
using HelpMyStreet.Contracts.ReportService.Response;
using HelpMyStreet.Utils.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class GetChartHandler : IRequestHandler<GetChartRequest, GetChartResponse>
    {
        private readonly IChartDataService _chartService;

        public GetChartHandler(IChartDataService chartService)
        {
            _chartService = chartService;
        }

        public async Task<GetChartResponse> Handle(GetChartRequest request, CancellationToken cancellationToken)
        {
            GetChartResponse response = new GetChartResponse()
            {
                Chart = new Chart()
            };

            List<DataPoint> dataPoints;

            switch (request.Chart.Chart)
            {
                case Charts.VolumeOfUsersByType:
                    dataPoints = await _chartService.GetVolumeByUserType(GroupAction.AddMember, request.GroupId, request.DateFrom, request.DateTo);
                    return new GetChartResponse()
                    {
                        Chart = new Chart()
                        {
                            XAxisName = "Month",
                            YAxisName = "Count",
                            DataPoints = dataPoints
                        }
                    };
                case Charts.VolumeOfUsersLeavingByMonth:
                    dataPoints = await _chartService.GetVolumeByUserType(GroupAction.RevokeMember, request.GroupId, request.DateFrom, request.DateTo);
                    return new GetChartResponse()
                    {
                        Chart = new Chart()
                        {
                            XAxisName = "Month",
                            YAxisName = "Count",
                            DataPoints = dataPoints
                        }
                    };
                case Charts.TotalGroupUsersByType:
                    dataPoints = await _chartService.TotalGroupUsersByType(request.GroupId);
                    return new GetChartResponse()
                    {
                        Chart = new Chart()
                        {
                            DataPoints = dataPoints
                        }
                    };
                default:
                    throw new Exception($"Unknown chart type { request.Chart.Chart}");
            }
        }
    }
}
