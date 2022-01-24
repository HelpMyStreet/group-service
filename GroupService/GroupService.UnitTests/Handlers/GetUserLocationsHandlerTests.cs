using GroupService.Core.Domains.Entities;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using GroupService.Handlers;
using HelpMyStreet.Contracts.AddressService.Response;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.UserService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetUserLocationsHandlerTests
    {
        private GetUserLocationsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private Mock<IUserService> _userService;
        private Mock<IAddressService> _addressService;
        private GetLocationsByDistanceResponse _getLocationsByDistanceResponse;
        private List<int> _groups;
        private List<GroupRadius> _groupRadii;
        private List<GroupLocation> _groupLocations;
        private GetUserByIDResponse _getUserByIdResponse;

        [SetUp]
        public void Setup()
        {
            SetupRepository();
            SetupUserService();
            SetupAddressService();

            _classUnderTest = new GetUserLocationsHandler(_repository.Object, _userService.Object, _addressService.Object);
               
        }

        private void SetupRepository()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetUserGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groups);

            _repository.Setup(x => x.GetGroupRadii(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groupRadii);

            _repository.Setup(x => x.GetGroupLocations(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()))
               .Returns(() => _groupLocations);

        }

        private void SetupUserService()
        {
            _userService = new Mock<IUserService>();
            _userService.Setup(x => x.GetUserByID(It.IsAny<int>()))
                .ReturnsAsync(() => _getUserByIdResponse);
        }

        private void SetupAddressService()
        {
            _addressService = new Mock<IAddressService>();
            _addressService.Setup(x => x.GetLocationsByDistance(It.IsAny<string>(), It.IsAny<int>()))
                .ReturnsAsync(() => _getLocationsByDistanceResponse);
        }

        [Test]
        public void WhenUserIsPartOfApex_ReturnLocations()
        {
            int userId = 1;
            _getUserByIdResponse = new GetUserByIDResponse()
            {
                User = new HelpMyStreet.Utils.Models.User()
                {
                    ID = userId,
                    PostalCode = "POSTCODE"
                }
            };


            _groups = new List<int>()
            {
               (int) Groups.ApexBankStaff,
               (int) Groups.Generic
            };

            _getLocationsByDistanceResponse = new GetLocationsByDistanceResponse()
            {
                LocationDistances = new List<LocationDistance>()
                {
                    new LocationDistance()
                    {
                        Location = Location.ForestRecreationGround,
                        DistanceFromPostCode = 200
                    },
                    new LocationDistance()
                    {
                        Location = Location.KingsMeadowCampus,
                        DistanceFromPostCode = 20
                    }
                }
            };

            _groupRadii = new List<GroupRadius>()
           {
               new GroupRadius()
               {
                   GroupID = (int) Groups.ApexBankStaff,
                   Radius = 2000
               },
               new GroupRadius()
               {
                   GroupID = (int) Groups.Generic,
                   Radius = 20
               }
           };

            _groupLocations = new List<GroupLocation>()
            {
                new GroupLocation()
                {
                    GroupID = (int) Groups.Generic,
                    Location = Location.ForestRecreationGround
                },
                new GroupLocation()
                {
                    GroupID = (int) Groups.ApexBankStaff,
                    Location = Location.ForestRecreationGround
                }
            };

             var result = _classUnderTest.Handle(new GetUserLocationsRequest()
            {
                UserID = userId
            }, CancellationToken.None).Result;

            _repository.Verify(x => x.GetUserGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupRadii(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupLocations(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()), Times.Once);
            _userService.Verify(x => x.GetUserByID(It.IsAny<int>()), Times.Once);
            _addressService.Verify(x => x.GetLocationsByDistance(It.IsAny<string>(), It.IsAny<int>()), Times.Once);


            Assert.AreEqual(new List<Location>() { Location.ForestRecreationGround }, result.Locations);
        }

        [Test]
        public void WhenUserIsNotPartOfApex_ReturnNoLocations()
        {
            int userId = 1;
            _getUserByIdResponse = new GetUserByIDResponse()
            {
                User = new HelpMyStreet.Utils.Models.User()
                {
                    ID = userId,
                    PostalCode = "POSTCODE"
                }
            };


            _groups = new List<int>()
            {
               (int) Groups.Generic
            };

            _getLocationsByDistanceResponse = new GetLocationsByDistanceResponse()
            {
                LocationDistances = new List<LocationDistance>()
                {
                    new LocationDistance()
                    {
                        Location = Location.ForestRecreationGround,
                        DistanceFromPostCode = 200
                    },
                    new LocationDistance()
                    {
                        Location = Location.KingsMeadowCampus,
                        DistanceFromPostCode = 20
                    },
                    new LocationDistance()
                    {
                        Location = Location.FranklinHallSpilsby,
                        DistanceFromPostCode = 40
                    }
                }
            };

            _groupRadii = new List<GroupRadius>()
           {
               new GroupRadius()
               {
                   GroupID = (int) Groups.Generic,
                   Radius = 20
               }
           };

            _groupLocations = new List<GroupLocation>()
            {
                new GroupLocation()
                {
                    GroupID = (int) Groups.Generic,
                    Location = Location.ForestRecreationGround
                },
                new GroupLocation()
                {
                    GroupID = (int) Groups.Generic,
                    Location = Location.FranklinHallSpilsby
                }
            };

            var result = _classUnderTest.Handle(new GetUserLocationsRequest()
            {
                UserID = userId
            }, CancellationToken.None).Result;

            _repository.Verify(x => x.GetUserGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupRadii(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupLocations(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()), Times.Once);
            _userService.Verify(x => x.GetUserByID(It.IsAny<int>()), Times.Once);
            _addressService.Verify(x => x.GetLocationsByDistance(It.IsAny<string>(), It.IsAny<int>()), Times.Once);
            Assert.AreEqual(0, result.Locations.Count);
        }

        [Test]
        public void WhenLocationIsWithinRadiusAndGroupIsAssociatedWithLocations_ReturnLocations()
        {
            int userId = 1;
            _getUserByIdResponse = new GetUserByIDResponse()
            {
                User = new HelpMyStreet.Utils.Models.User()
                {
                    ID = userId,
                    PostalCode = "POSTCODE"
                }
            };


            _groups = new List<int>()
            {
               (int) Groups.Generic
            };

            _getLocationsByDistanceResponse = new GetLocationsByDistanceResponse()
            {
                LocationDistances = new List<LocationDistance>()
                {
                    new LocationDistance()
                    {
                        Location = Location.ForestRecreationGround,
                        DistanceFromPostCode = 15
                    },
                    new LocationDistance()
                    {
                        Location = Location.KingsMeadowCampus,
                        DistanceFromPostCode = 200
                    },
                    new LocationDistance()
                    {
                        Location = Location.FranklinHallSpilsby,
                        DistanceFromPostCode = 20
                    }
                }
            };

            _groupRadii = new List<GroupRadius>()
           {
               new GroupRadius()
               {
                   GroupID = (int) Groups.Generic,
                   Radius = 20
               }
           };

            _groupLocations = new List<GroupLocation>()
            {
                new GroupLocation()
                {
                    GroupID = (int) Groups.Generic,
                    Location = Location.ForestRecreationGround
                },
                new GroupLocation()
                {
                    GroupID = (int) Groups.Generic,
                    Location = Location.FranklinHallSpilsby
                }
            };

            var result = _classUnderTest.Handle(new GetUserLocationsRequest()
            {
                UserID = userId
            }, CancellationToken.None).Result;

            _repository.Verify(x => x.GetUserGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupRadii(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupLocations(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()), Times.Once);
            _userService.Verify(x => x.GetUserByID(It.IsAny<int>()), Times.Once);
            _addressService.Verify(x => x.GetLocationsByDistance(It.IsAny<string>(), It.IsAny<int>()), Times.Once);

            Assert.AreEqual(true, result.Locations.Contains(Location.FranklinHallSpilsby));
            Assert.AreEqual(true, result.Locations.Contains(Location.ForestRecreationGround));
            Assert.AreEqual(false, result.Locations.Contains(Location.KingsMeadowCampus));
        }


        [Test]
        public void WhenGroupHasNoLocations_ReturnNoLocations()
        {
            int userId = 1;
            _getUserByIdResponse = new GetUserByIDResponse()
            {
                User = new HelpMyStreet.Utils.Models.User()
                {
                    ID = userId,
                    PostalCode = "POSTCODE"
                }
            };

            _groups = new List<int>()
            {
               (int) Groups.AgeConnectsCardiff
            };

            _getLocationsByDistanceResponse = new GetLocationsByDistanceResponse()
            {
                LocationDistances = new List<LocationDistance>()
                {
                    new LocationDistance()
                    {
                        Location = Location.ForestRecreationGround,
                        DistanceFromPostCode = 15
                    },
                    new LocationDistance()
                    {
                        Location = Location.KingsMeadowCampus,
                        DistanceFromPostCode = 200
                    },
                    new LocationDistance()
                    {
                        Location = Location.FranklinHallSpilsby,
                        DistanceFromPostCode = 20
                    }
                }
            };

            _groupRadii = new List<GroupRadius>()
           {
               new GroupRadius()
               {
                   GroupID = (int) Groups.AgeConnectsCardiff,
                   Radius = 20
               }
           };

            _groupLocations = new List<GroupLocation>();

            var result = _classUnderTest.Handle(new GetUserLocationsRequest()
            {
                UserID = userId
            }, CancellationToken.None).Result;

            _repository.Verify(x => x.GetUserGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupRadii(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupLocations(It.IsAny<List<int>>(), It.IsAny<CancellationToken>()), Times.Once);
            _userService.Verify(x => x.GetUserByID(It.IsAny<int>()), Times.Once);
            _addressService.Verify(x => x.GetLocationsByDistance(It.IsAny<string>(), It.IsAny<int>()), Times.Once);

            Assert.AreEqual(0, result.Locations.Count);
        }
    }
}