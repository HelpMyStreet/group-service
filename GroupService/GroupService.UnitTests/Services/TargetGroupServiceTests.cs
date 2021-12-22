using GroupService.Core.Domains.Entities;
using GroupService.Core.Interfaces.Repositories;
using GroupService.Core.Interfaces.Services;
using GroupService.Core.Services;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
using HelpMyStreet.Contracts.RequestService.Request;
using HelpMyStreet.Contracts.RequestService.Response;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests.Services
{
    public class TargetGroupServiceTests
    {
        private TargetGroupService _classUnderTest;
        private Mock<IRepository> _repository;
        private Dictionary<int, List<int>> _childGroups;
        private Dictionary<int, Group> _group;
        private Dictionary<int, List<int>> _groupMembers;
        private Dictionary<int, GetRequestHelpFormVariantResponse> _getRequestHelpFormVariantResponse;

        [SetUp]
        public void Setup()
        {
            SetupRepository();
            _classUnderTest = new TargetGroupService(_repository.Object);
               
        }

        private void SetupRepository()
        {
            _repository = new Mock<IRepository>();

            _groupMembers = new Dictionary<int, List<int>>();
            _groupMembers.Add(-1, new List<int>() { 1, 2, 3 });
            _groupMembers.Add(-2, new List<int>() { 4, 5});
            _groupMembers.Add(-3, new List<int>() { 6, 7 });

            _getRequestHelpFormVariantResponse = new Dictionary<int, GetRequestHelpFormVariantResponse>();
            _getRequestHelpFormVariantResponse.Add(-1, new GetRequestHelpFormVariantResponse() { TargetGroups = TargetGroups.GenericGroup });
            _getRequestHelpFormVariantResponse.Add(-2, new GetRequestHelpFormVariantResponse() { TargetGroups = TargetGroups.ThisGroupAndChildren });
            _getRequestHelpFormVariantResponse.Add(-4, new GetRequestHelpFormVariantResponse() { TargetGroups = TargetGroups.ParentGroup });
            _getRequestHelpFormVariantResponse.Add(-5, new GetRequestHelpFormVariantResponse() { TargetGroups = TargetGroups.SiblingsAndParentGroup });


            _group = new Dictionary<int, Group>();
            _group.Add(-1, new Group() { ParentGroupId = null, GroupId = -1 });
            _group.Add(-2, new Group() { ParentGroupId = null, GroupId = -2 });
            _group.Add(-4, new Group() { ParentGroupId = -1, GroupId = -4 });
            _group.Add(-5, new Group() { ParentGroupId = -1, GroupId = -5 });


            _childGroups = new Dictionary<int, List<int>>();
            _childGroups.Add(-2, new List<int>() { -3, -2 });
            _childGroups.Add(-5, new List<int>() { -1 });
            _childGroups.Add(-1, new List<int>() { -5 });


            _repository.Setup(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .Returns(((int a,string b, CancellationToken c) => _getRequestHelpFormVariantResponse[a]));

            _repository.Setup(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns((int a, CancellationToken b) => _group[a]);

            _repository.Setup(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                 .Returns((int a, CancellationToken b) => _childGroups[a]);

            _repository.Setup(x => x.GetGroupMembers(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                 .Returns((int a, CancellationToken b) => _groupMembers[a]);

        }


        [TestCase(-1, "", 0, 0 ,1)]
        [TestCase(-2, "", 0, 1 ,2)]
        [TestCase(-4, "", 1, 0, 1)]
        [TestCase(-5, "", 1, 1, 1)]
        [Test]
        public async Task GetTargetGroups_HappyPath(int referringGroupId, string source, int callsToGetGroupById, int callsToGetGroupAndChildGroups, int groupCount)
        {
            var response = await _classUnderTest.GetTargetGroups(referringGroupId, source, CancellationToken.None);
            _repository.Verify(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
            _repository.Verify(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(callsToGetGroupById));
            _repository.Verify(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(callsToGetGroupAndChildGroups));
            Assert.AreEqual(groupCount, response.ToList().Count);
        }

        [TestCase(-1, "",1, 3)]
        [TestCase(-2, "", 2, 4)]
        [Test]
        public async Task GetTargetGroupsMembers_HappyPath(int referringGroupId, string source, int callsToGetGroupMembers, int memberCount)
        {
            var response = await _classUnderTest.GetTargetGroupsMembers(referringGroupId, source, CancellationToken.None);
            _repository.Verify(x => x.GetGroupMembers(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(callsToGetGroupMembers));
            Assert.AreEqual(memberCount, response.ToList().Count);
        }
    }
}