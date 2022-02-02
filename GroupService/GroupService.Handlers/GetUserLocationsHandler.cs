using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Utils.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.Handlers
{
    public class GetUserLocationsHandler : IRequestHandler<GetUserLocationsRequest, GetUserLocationsResponse>
    {
        private readonly IRepository _repository;
        private readonly IUserService _userService;
        private readonly IAddressService _addressService;
        public GetUserLocationsHandler(IRepository repository, IUserService userService, IAddressService addressService)
        {
            _repository = repository;
            _userService = userService;
            _addressService = addressService;
        }

        public async Task<GetUserLocationsResponse> Handle(GetUserLocationsRequest request, CancellationToken cancellationToken)
        {
            List<int> groups = _repository.GetUserGroups(request.UserID.Value, cancellationToken);

            var user = await _userService.GetUserByID(request.UserID.Value);

           var getLocationsByDistanceResponse  = await _addressService.GetLocationsByDistance(user.User.PostalCode, 2000);

            var groupRadii = _repository.GetMaxShiftSupportActivityRadius(groups, cancellationToken);

            var groupLocations = _repository.GetGroupLocations(groups, cancellationToken);

            List<Location> userLocations = new List<Location>();
            foreach(Core.Domains.Entities.GroupLocation gl in groupLocations)
            {
                var groupRadius = groupRadii.FirstOrDefault(w => w.GroupID == gl.GroupID);

                var locationDistance = getLocationsByDistanceResponse.LocationDistances
                    .FirstOrDefault(x => x.Location == gl.Location);

                if(locationDistance!=null && groupRadius!=null && locationDistance.DistanceFromPostCode<=groupRadius.Radius)
                {
                    userLocations.Add(gl.Location);
                }
            }

            return new GetUserLocationsResponse()
            {
                Locations = userLocations
            };
        }
    }
}
