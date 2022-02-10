using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Contracts.GroupService.Response;
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
    public class GetNewRequestActionsSimplifiedHandlerTests
    {
        private GetNewRequestActionsSimplifiedHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private List<int> _groups;
        private HelpMyStreet.Utils.Models.Group _group;
        private GetRequestHelpFormVariantResponse _getRequestHelpFormVariantResponse;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _groups);

            _repository.Setup(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .Returns(() => _getRequestHelpFormVariantResponse);

            _repository.Setup(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()))
                .Returns(() => _group);

            _classUnderTest = new GetNewRequestActionsSimplifiedHandler(_repository.Object);               
        }

        [Test]
        public async Task GroupWithGenericGroups_ReturnsCorrectActions()
        {
            int groupId = (int)Groups.Generic;
            _getRequestHelpFormVariantResponse = new GetRequestHelpFormVariantResponse()
            {
                TargetGroups = TargetGroups.GenericGroup,
            };
            var result = await _classUnderTest.Handle(new GetNewRequestActionsSimplifiedRequest()
            {
                GroupId = groupId,
                Source = string.Empty,
                SupportActivity = new HelpMyStreet.Contracts.RequestService.Request.SupportActivityRequest()
                {
                    SupportActivities = new List<SupportActivities>()
                    { SupportActivities.Shopping}
                }
            }, CancellationToken.None);

            _repository.Verify(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));
            _repository.Verify(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));

            Assert.AreEqual(new List<int>() { groupId }, result.RequestTaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(new List<int>() { groupId }, result.RequestTaskActions[NewTaskAction.NotifyMatchingVolunteers]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SetStatusToOpen]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SendRequestorConfirmation]);
        }

        [Test]
        public async Task GroupWithParentGroup_ReturnsCorrectActions()
        {
            int groupId = (int)Groups.LincolnPCN;
            _getRequestHelpFormVariantResponse = new GetRequestHelpFormVariantResponse()
            {
                TargetGroups = TargetGroups.ParentGroup,
            };

            _group = new HelpMyStreet.Utils.Models.Group()
            {
                GroupId = groupId,
                ParentGroupId = (int)Groups.LincolnshireVolunteers
            };

            var result = await _classUnderTest.Handle(new GetNewRequestActionsSimplifiedRequest()
            {
                GroupId = groupId,
                Source = string.Empty,
                SupportActivity = new HelpMyStreet.Contracts.RequestService.Request.SupportActivityRequest()
                {
                    SupportActivities = new List<SupportActivities>()
                    { SupportActivities.Shopping}
                }
            }, CancellationToken.None);

            _repository.Verify(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));

            Assert.AreEqual(new List<int>() { (int)Groups.LincolnshireVolunteers }, result.RequestTaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(new List<int>() { (int)Groups.LincolnshireVolunteers }, result.RequestTaskActions[NewTaskAction.NotifyMatchingVolunteers]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SetStatusToOpen]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SendRequestorConfirmation]);
        }

        [Test]
        public async Task GroupWithSiblingsAndParentGroup_ReturnsCorrectActions()
        {
            int groupId = (int)Groups.LincolnPCN;
            _getRequestHelpFormVariantResponse = new GetRequestHelpFormVariantResponse()
            {
                TargetGroups = TargetGroups.SiblingsAndParentGroup,
            };

            _group = new HelpMyStreet.Utils.Models.Group()
            {
                GroupId = groupId,
                ParentGroupId = (int)Groups.LincolnshireVolunteers
            };

            _groups = new List<int>()
            {
                groupId,
                (int)Groups.LincolnshireVolunteers
            };

            var result = await _classUnderTest.Handle(new GetNewRequestActionsSimplifiedRequest()
            {
                GroupId = groupId,
                Source = string.Empty,
                SupportActivity = new HelpMyStreet.Contracts.RequestService.Request.SupportActivityRequest()
                {
                    SupportActivities = new List<SupportActivities>()
                    { SupportActivities.Shopping}
                }
            }, CancellationToken.None);

            _repository.Verify(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(1));

            Assert.AreEqual(new List<int>() { (int)Groups.LincolnPCN, (int)Groups.LincolnshireVolunteers }, result.RequestTaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(new List<int>() { (int)Groups.LincolnPCN, (int)Groups.LincolnshireVolunteers }, result.RequestTaskActions[NewTaskAction.NotifyMatchingVolunteers]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SetStatusToOpen]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SendRequestorConfirmation]);
        }

        [Test]
        public async Task GroupWithThisGroup_ReturnsCorrectActions()
        {
            int groupId = (int)Groups.Generic;
            _getRequestHelpFormVariantResponse = new GetRequestHelpFormVariantResponse()
            {
                TargetGroups = TargetGroups.ThisGroup,
            };

            var result = await _classUnderTest.Handle(new GetNewRequestActionsSimplifiedRequest()
            {
                GroupId = groupId,
                Source = string.Empty,
                SupportActivity = new HelpMyStreet.Contracts.RequestService.Request.SupportActivityRequest()
                {
                    SupportActivities = new List<SupportActivities>()
                    { SupportActivities.Shopping}
                }
            }, CancellationToken.None);

            _repository.Verify(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));
            _repository.Verify(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));

            Assert.AreEqual(new List<int>() { groupId }, result.RequestTaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(new List<int>() { groupId }, result.RequestTaskActions[NewTaskAction.NotifyMatchingVolunteers]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SetStatusToOpen]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SendRequestorConfirmation]);
        }

        [Test]
        public async Task GroupWithThisGroupAndChildren_ReturnsCorrectActions()
        {
            int groupId = (int)Groups.LincolnPCN;
            _getRequestHelpFormVariantResponse = new GetRequestHelpFormVariantResponse()
            {
                TargetGroups = TargetGroups.ThisGroupAndChildren,
            };

            _groups = new List<int>()
            {
                groupId,
                (int)Groups.LincolnshireVolunteers
            };

            var result = await _classUnderTest.Handle(new GetNewRequestActionsSimplifiedRequest()
            {
                GroupId = groupId,
                Source = string.Empty,
                SupportActivity = new HelpMyStreet.Contracts.RequestService.Request.SupportActivityRequest()
                {
                    SupportActivities = new List<SupportActivities>()
                    { SupportActivities.Shopping}
                }
            }, CancellationToken.None);

            _repository.Verify(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));
            _repository.Verify(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(1));

            Assert.AreEqual(new List<int>() { (int)Groups.LincolnPCN, (int)Groups.LincolnshireVolunteers }, result.RequestTaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(new List<int>() { (int)Groups.LincolnPCN, (int)Groups.LincolnshireVolunteers }, result.RequestTaskActions[NewTaskAction.NotifyMatchingVolunteers]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SetStatusToOpen]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SendRequestorConfirmation]);
        }

        [Test]
        public async Task GroupWithRequestRequiresApproval_ReturnsCorrectActions()
        {
            int groupId = (int)Groups.Generic;
            _getRequestHelpFormVariantResponse = new GetRequestHelpFormVariantResponse()
            {
                TargetGroups = TargetGroups.GenericGroup,
                RequestsRequireApproval = true
            };
            var result = await _classUnderTest.Handle(new GetNewRequestActionsSimplifiedRequest()
            {
                GroupId = groupId,
                Source = string.Empty,
                SupportActivity = new HelpMyStreet.Contracts.RequestService.Request.SupportActivityRequest()
                {
                    SupportActivities = new List<SupportActivities>()
                    { SupportActivities.Shopping}
                }
            }, CancellationToken.None);

            _repository.Verify(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));
            _repository.Verify(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));

            Assert.AreEqual(new List<int>() { groupId }, result.RequestTaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(new List<int>() { groupId }, result.RequestTaskActions[NewTaskAction.NotifyGroupAdmins]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SendRequestorConfirmation]);
        }

        [Test]
        public async Task ShiftRequest_ReturnsCorrectActions()
        {
            int groupId = (int)Groups.Generic;
            _getRequestHelpFormVariantResponse = new GetRequestHelpFormVariantResponse()
            {
                TargetGroups = TargetGroups.GenericGroup,
                RequestsRequireApproval = false
            };
            var result = await _classUnderTest.Handle(new GetNewRequestActionsSimplifiedRequest()
            {
                GroupId = groupId,
                Source = string.Empty,
                SupportActivity = new HelpMyStreet.Contracts.RequestService.Request.SupportActivityRequest()
                {
                    SupportActivities = new List<SupportActivities>()
                    { SupportActivities.VaccineSupport}
                }
            }, CancellationToken.None);

            _repository.Verify(x => x.GetRequestHelpFormVariant(It.IsAny<int>(), It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Exactly(1));
            _repository.Verify(x => x.GetGroupById(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));
            _repository.Verify(x => x.GetGroupAndChildGroups(It.IsAny<int>(), It.IsAny<CancellationToken>()), Times.Exactly(0));

            Assert.AreEqual(new List<int>() { groupId }, result.RequestTaskActions[NewTaskAction.MakeAvailableToGroups]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SetStatusToOpen]);
            Assert.AreEqual(null, result.RequestTaskActions[NewTaskAction.SendRequestorConfirmation]);
        }

    }
}