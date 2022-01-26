using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts.ReportService;
using HelpMyStreet.Contracts.ReportService.Request;
using HelpMyStreet.Contracts.ReportService.Response;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class GetChartHandler : IRequestHandler<GetChartRequest, GetChartResponse>
    {
        private readonly IRepository _repository;

        public GetChartHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetChartResponse> Handle(GetChartRequest request, CancellationToken cancellationToken)
        {
            GetChartResponse response = new GetChartResponse()
            {
                Chart = new Chart()
            };

            switch (request.Chart.Chart)
            {
                case HelpMyStreet.Utils.Enums.Charts.VolumeOfUsersByType:
                    var activitiesByMonth = await _repository.GetVolumeByUserType(request.GroupId);
                    response.Chart = activitiesByMonth;
                    break;
                default:
                    throw new Exception($"Unknown chart type { request.Chart.Chart}");
            }

            return response;
        }
    }
}
