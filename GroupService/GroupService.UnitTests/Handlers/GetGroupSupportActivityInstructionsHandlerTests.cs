using GroupService.Core.Interfaces.Repositories;
using GroupService.Handlers;
using HelpMyStreet.Contracts.GroupService.Request;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using HelpMyStreet.Utils.Utils;
using Moq;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GroupService.UnitTests
{
    public class GetGroupSupportActivityInstructionsHandlerTests
    {
        private GetGroupSupportActivityInstructionsHandler _classUnderTest;
        private Mock<IRepository> _repository;
        private Group _group;
        private Instructions _instructions;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IRepository>();
            _repository.Setup(x => x.GetGroupSupportActivityInstructions(It.IsAny<int>(), It.IsAny<SupportActivities>(),  It.IsAny<CancellationToken>()))
                .Returns(() => _instructions);

            _classUnderTest = new GetGroupSupportActivityInstructionsHandler(_repository.Object);
               
        }

        [Test]
        public void WhenGroupIdAndSupportActivityIsValid_ReturnInstructions()
        {
            _instructions = new Instructions()
            {
                Intro = "INTRO",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Heading",
                        Detail = "Detail"
                    }
                },
                Close = "Close",
                SupportActivityInstructions = SupportActivityInstructions.HMS_Shopping
            };
            
            var result = _classUnderTest.Handle(new GetGroupSupportActivityInstructionsRequest()
            {
                GroupId = -1,
                SupportActivityType = new SupportActivityType()
                {
                    SupportActivity = SupportActivities.Shopping
                }
            },CancellationToken.None).Result;

            Assert.AreEqual(_instructions, result.Instructions);
        }

        [Test]
        public void WhenGroupIdSupportActivityIsInValid_ThrowsError()
        {
            int groupId = 1;
            SupportActivities activity = SupportActivities.Shopping;

            _repository.Setup(x => x.GetGroupSupportActivityInstructions(It.IsAny<int>(), It.IsAny<SupportActivities>(), It.IsAny<CancellationToken>()))
               .Throws(new Exception($"Unable to find support activity instructions for GroupId={groupId} and SupportActivity={activity}"));

           Exception ex = Assert.ThrowsAsync<Exception>(() => _classUnderTest.Handle(new GetGroupSupportActivityInstructionsRequest()
           {
                GroupId = groupId,
                SupportActivityType = new SupportActivityType() { SupportActivity = activity}
           }, CancellationToken.None));

            Assert.AreEqual($"Unable to find support activity instructions for GroupId={groupId} and SupportActivity={activity}", ex.Message);
        }
    }
}