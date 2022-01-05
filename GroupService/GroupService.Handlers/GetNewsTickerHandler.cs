using GroupService.Core.Interfaces.Repositories;
using HelpMyStreet.Contracts;
using HelpMyStreet.Utils.Models;
using MediatR;
using System.Collections.Generic;
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

            int volunteerCount = await _repository.MemberVolunterCount(request.GroupId);
            int newVolunteerCountInLast7Days = await _repository.MemberVolunterCountLastXDays(request.GroupId, 7);
            int newVolunteerCountInLastDay = await _repository.MemberVolunterCountLastXDays(request.GroupId, 1);

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
