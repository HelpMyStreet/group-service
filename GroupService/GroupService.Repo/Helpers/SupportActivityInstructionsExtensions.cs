using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using HelpMyStreet.Utils.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System;
using System.Linq;
using SupportActivityInstructionsEnum = HelpMyStreet.Utils.Enums.SupportActivityInstructions;

namespace GroupService.Repo.Helpers
{
    public static class SupportActivityInstructionsExtensions
    {
        private const double NATIONAL_RADIUS = 2000d;
        public static void SetEnumSupportActivityInstructionsExtensionsData(this EntityTypeBuilder<EnumSupportActivityInstructions> entity)
        {
            var supportActivityInstructions = Enum.GetValues(typeof(SupportActivityInstructionsEnum)).Cast<SupportActivityInstructionsEnum>();

            foreach (var instruction in supportActivityInstructions)
            {
                entity.HasData(new EnumSupportActivityInstructions { Id = (int)instruction, Name = instruction.ToString() });
            }
        }

        private static Instructions GetInstructions_HmsShopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_Shopping,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Confirm what they need and agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",                        
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsOtherPurchase()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_OtherPurchase,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",                        
                        Detail = "Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsGeneral()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_General,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Get in touch with the person who needs the help to confirm what they need. If someone else has requested the help on their behalf it may be useful to give them a call too.",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Provide the help that’s needed.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsFriendlyChat()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_FriendlyChat,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Give them a call",
                        Detail = "Be a friendly voice at the end of the phone and have a good chat.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsHomework()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_Homework,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Get in touch to find out how you can help.",
                    },
                    new Step()
                    {
                        Heading = "Solve the problem… hopefully!",
                        Detail = "If you’re able, give them the support they need.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due (including if you don’t know the answer!), let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsCheckIn()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_CheckIn,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Check in",
                        Detail = "Give them a call or knock on the door to find out if they’re OK. You can also see if they need anything and let them know someone’s asking after them.",
                    },
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "A check in is usually requested by someone else for a friend, neighbour or loved one. Give the person who requested the help a call to let them know how it went.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsFaceCovering()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_FaceCovering,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Confirm what they need and agree how they will pay you back (£2 - £3 per face covering to cover the cost of materials plus the cost of postage if required). You can find out more about secure payment methods in our [FAQs](/questions#5).",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt.",
                    },
                    new Step()
                    {
                        Heading = "Let them know they’re on the way",
                        Detail = "Drop the recipient a note to let them know they’re on the way.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_FtlosFaceCovering()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.FTLOS_FaceCovering,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Confirm what they need. Let them know that they can make a donation [here](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet) (suggested £3 - £4 per face covering). If you need to post the face coverings let them know if you’ll need them to cover the cost of postage on top of the donation and agree how they will pay you back. You can find out more about secure payment methods in our [FAQs](/questions#5).",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Make the face coverings and deliver them (or pop them in the post). If you need to claim back the cost of postage don’t forget to keep a copy of the receipt. If you need more materials email mailto:requestmaterials.ftlos@outlook.com.",
                    },
                    new Step()
                    {
                        Heading = "Let them know they’re on the way",
                        Detail = "Drop the recipient a note to let them know they’re on the way and share a link to [our fundraising page](https://www.gofundme.com/f/for-the-love-of-scrubs-face-coverings?utm_source=widget&utm_medium=referral&utm_campaign=p_cp+share-sheet).",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKLincoln_V4V()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKLincoln_V4V,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK Lincoln & South Lincolnshire)",
                        Detail = "Please contact volunteering@ageuklsl.org.uk to arrange collection of a pre-made wellbeing package from one of our sites. We’ll also give you all the details you need for the delivery.",
                    },
                    new Step()
                    {
                        Heading = "Deliver the package",
                        Detail = "Use the details provided to deliver the package. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. If you have any concerns about the person you visited let us know immediately by emailing volunteering@ageuklsl.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKWirral_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKWirral_Shopping,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Go shopping",
                        Detail = "Pick up their shopping, you will find their shopping list and any specific instructions in “My Requests”. You’ll need to pay for the shopping on your own card before claiming the money back.",
                    },
                    new Step()
                    {
                        Heading = "Send us a copy of the receipt",
                        Detail = "Write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.",
                    },
                    new Step()
                    {
                        Heading = "Drop off the shopping",
                        Detail = "Drop off the shopping along with the original copy of the receipt. You’ll find their details in “My Requests”.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKWirral_VolunteerSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKWirral_VolunteerSupport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    },
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKWirral_General()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKWirral_General,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Provide the help that’s needed.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKWirral_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKWirral_Prescriptions,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Collect the prescription",
                        Detail = "Collect the prescription from the pharmacy, you will find details of the pharmacy in “My Requests”. If the prescription needs paying for, you’ll need to pay for it on your own card before claiming the money back.",
                    },
                    new Step()
                    {
                        Heading = "Send us a copy of the receipt (if you paid)",
                        Detail = "If you paid for the prescription, write the name of the client on the receipt and email us a photograph to mailto:emergencyvols@ageukwirral.org.uk. We’ll transfer the money as soon as possible via bank transfer.",
                    },
                    new Step()
                    {
                        Heading = "Drop off the medication",
                        Detail = "Drop off the medication (along with the original copy of the receipt if you paid for it). You’ll find their details in “My Requests”",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKLSL_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKLSL_Shopping,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK Lincoln & South Lincolnshire)",
                        Detail = "Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.",
                    },
                    new Step()
                    {
                        Heading = "Purchase the shopping items",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },  
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKLSL_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKLSL_Prescriptions,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK Lincoln & South Lincolnshire)",
                        Detail = "Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.",
                    },
                    new Step()
                    {
                        Heading = "Collecting the prescription",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKLSL_General()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKLSL_General,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK Lincoln & South Lincolnshire)",
                        Detail = "Please contact mailto:volunteering@ageuklsl.org.uk to receive further information about this request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_MealtimeCompanion()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKSKC_MealtimeCompanion,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK South Kent Coast)",
                        Detail = "For the Folkestone area please contact the Marigold Centre on 01303 279031, or for the Deal area contact the Deal Centre on 01304 372608 to book your meal. (You provide the company; we’ll provide the food!).",
                    },
                    new Step()
                    {
                        Heading = "Enjoy your dinner together",
                        Detail = "Use the details given to you to meet up at the person’s chosen mealtime (usually between 12 noon and 1pm). Have a chat and provide some company for the person you’re joining.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.",                        
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_MealOnWheels()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKSKC_MealsToYourDoor,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK South Kent Coast)",
                        Detail = "Please contact mailto:volunteering@ageukskc.org.uk to arrange for the collection of hot meals and the delivery details.",
                    },
                    new Step()
                    {
                        Heading = "Deliver the meals",
                        Detail = "Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk."                        
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HMS_VolunteerSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_VolunteerSupport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HMS_EmergencySupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_EmergencySupport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNWK_Other()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNWK_Other,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK North West Kent)",
                        Detail = "Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:contactus@ageuknorthwestkent.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_Other()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKSKC_Other,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK South Kent Coast)",
                        Detail = "Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk ."
                   }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKSKC_Prescriptions,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK South Kent Coast)",
                        Detail = "Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.",
                    },
                    new Step()
                    {
                        Heading = "Collecting the prescription",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKSKC_Shopping,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK South Kent Coast)",
                        Detail = "Please contact mailto:volunteering@ageukskc.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.",
                    },
                    new Step()
                    {
                        Heading = "Purchase the shopping items",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNWK_MealsToYourDoor()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNWK_MealsToYourDoor,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK North West Kent)",
                        Detail = "Please contact mailto:kirsty.groves@ageuknorthwestkent.org.uk to arrange for the collection of hot meals and the delivery details.",
                    },
                    new Step()
                    {
                        Heading = "Deliver the meals",
                        Detail = "Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNWK_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNWK_Prescriptions,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK North West Kent)",
                        Detail = "Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request. We’ll also give you all the details you need for the prescription collection and delivering the medication.",
                    },
                    new Step()
                    {
                        Heading = "Collecting the prescription",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:contactus@ageuknorthwestkent.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNWK_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNWK_Shopping,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK North West Kent)",
                        Detail = "Please contact mailto:contactus@ageuknorthwestkent.org.uk to receive further information about this request. We’ll also give you all the details you need for the delivering the items.",
                    },
                    new Step()
                    {
                        Heading = "Purchase the shopping items",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat to say hello and see how they’re getting on.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_FriendlyChat()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKFANDS_FriendlyChat,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Give them a call",
                        Detail = "Be a friendly voice at the end of the phone and have a good chat.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us " +
                        "(and anyone else involved with the request) know it’s been completed. You’ll still be able to find their " +
                        "contact details in “My Requests” in case you need to get back in touch. If someone else has requested " +
                        "the help on their behalf it may be useful to give them a call to let them know how it went.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_MealtimeCompanion()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKFANDS_MealtimeCompanion,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK Faversham & Sittingbourne)",
                        Detail = "Please contact mailto:volunteering@ageukfaversham.org.uk to book your meal (you provide the company, we’ll provide the food!).",
                    },
                    new Step()
                    {
                        Heading = "Enjoy your dinner together",
                        Detail = "Use the details given to you to meet up at your chosen mealtime. Have a chat and provide some company " +
                        "for the person you’re joining."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re home, mark the request as complete in “My Requests”. If you have any concerns " +
                        "about the person you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_MealsToYourDoor()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKFANDS_MealsToYourDoor,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK Faversham & Sittingbourne)",
                        Detail = "Please contact mailto:volunteering@ageukfaversham.org.uk to arrange for the collection of hot meals and the delivery details.",
                    },
                    new Step()
                    {
                        Heading = "Deliver the meals",
                        Detail = "Use the details given to you to deliver the meals. It would be great if you could also stop to say hello and " +
                        "see how they’re getting on."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the " +
                        "person you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_Transport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKFANDS_Transport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the transport",
                        Detail = "Use the details given to you to pick up and drop off as required."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_VolunteerSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKFANDS_VolunteerSupport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_Other()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKFANDS_Other,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact us (Age UK Faversham & Sittingbourne)",
                        Detail = "Please contact mailto:volunteering@ageukfaversham.org.uk to receive further information about this request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request. It would be great if you could also stop for a quick chat " +
                        "to say hello and see how they’re getting on."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests”. If you have any concerns about the person " +
                        "you visited let us know immediately by emailing mailto:volunteering@ageukfaversham.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_LincolnVaccineSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.Lincoln_VaccineSupport,
                ActivityDetails = $"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. " +
                $"Duties may vary by location and could include a range of indoor or outdoor activities, " +
                $"such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site," +
                $" general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept " +
                $"this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the " +
                $"shift or by clicking “View more info” on accepted shifts in the “My Shifts” tab.",
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Check the request details",
                        Detail = $"Please read the [role description and useful information](/pdf/lincs-vaccination-support/lincs-vaccination-support-role-description.pdf) " +
                        $"attachment for full details of the role. " +
                        $"Volunteers may also be asked to participate in regular lateral flow testing, you can find more information [here](/pdf/lincs-vaccination-support/lateral-flow-testing-for-vaccination-support-volunteers.pdf)."

                    },
                    new Step()
                    {
                        Heading = "Attending your shift",
                        Detail = $"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather " +
                        $"(e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the " +
                        $"details in the “My Shifts” tab but searching for shifts with the status “Done”."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer."
            };
        }

        private static Instructions GetInstructions_LincolnStamfordVaccineSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.Lincoln_Stamford_VaccineSupport,
                ActivityDetails = $"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. " +
                $"Duties may vary by location and could include a range of indoor or outdoor activities, " +
                $"such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site," +
                $" general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept " +
                $"this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the " +
                $"shift or by clicking “View more info” on accepted shifts in the “My Shifts” tab. " +
                $"If you have any questions about this volunteering opportunity or are at high risk from COVID-19, " +
                $"please email Lyndsay at mailto:lyndsay.money@nhs.net before accepting the shift.",
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Check the request details",
                        Detail = $"Please read the [role description and useful information](/pdf/lincs-vaccination-support/outdoor-volunteer-role-description-pcn-four-counties.pdf) " +
                        $"attachment for full details of the role. " +
                        $"Volunteers may also be asked to participate in regular lateral flow testing, you can find more information [here](/pdf/lincs-vaccination-support/lateral-flow-testing-for-vaccination-support-volunteers.pdf)."
                    },
                    new Step()
                    {
                        Heading = "Attending your shift",
                        Detail = $"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate " +
                        $"clothing for the weather (e.g. a warm / waterproof coat). On your first shift at St. Mary’s please also **bring some photo ID** " +
                        $"so we can take a copy for our records. Once you’ve completed a shift it will be marked as complete automatically. " +
                        $"You’ll still be able to find all the details in the “My Shifts” tab but searching for shifts with the status “Done”."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer."
            };
        }


        private static Instructions GetInstructions_AgeConnectCardiff_FriendlyChat()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_FriendlyChat,
                ActivityDetails = $"This client has been assessed as being isolated (little or no family support) and has " +
                $"requested someone ring them on a regular basis for a chat and to brighten their day. We have explained to the " +
                $"client that a volunteer will be calling, but they might have forgotten so be prepared to introduce yourself and " +
                $"explain your role. Agree on your first call when and how often you will be calling, we suggest keeping to the same " +
                $"time each week, but it can be flexible. Do not forget to “use 141” to withhold your number (otherwise, you might receive " +
                $"a call back at unsuitable hours). Feel free to browse the internet for ideas if you struggle to get the conversation going.",
                Intro = $"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Give the client a call",
                        Detail = $"Be a friendly voice at the end of the phone and have a good chat."
                    },
                    new Step()
                    {
                        Heading = "Contact your volunteer manager",
                        Detail = $"Once you have completed your first call, let us know by contacting your volunteer manager via email, phone or text. You will find their contact details listed as the ‘Requester’ on the accepted request."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"Only mark the request as complete when no more calls are required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support."
                    },
                    new Step()
                    {
                        Heading = "Share any concerns or updates",
                        Detail = $"Please make sure to tell us if you have any concerns about the client, or if they do not want the call anymore. We would also just love to hear how you’re getting on!"
                    }
                },
                Close = "If for any reason you can’t complete the request - or you need to stop making calls - let us know by updating the accepted request and clicking “Can’t Do”, this will allow us to find a new volunteer to help."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_InPersonBefriending()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_InPersonBefriending,
                ActivityDetails = $"As a Befriender you will visit older people who are experiencing loneliness and isolation to offer " +
                $"support and companionship.  It could be that you are the only person they see that day, or even that week. The client " +
                $"will have been assessed as being isolated and requested someone visit them regularly for a chat and to see someone new. " +
                $"We are looking for you to visit and have a friendly chat for at least one hour each time. We will arrange your first visit " +
                $"with the client (and most likely be there to introduce you, but this might not apply in all cases). On your first visit be " +
                $"prepared to introduce yourself – take along your ID badge or a letter from Age Connects explaining who you are. Agree with the " +
                $"client when and how often you will be visiting. We suggest keeping to the same time each week, but it can be flexible. Expenses " +
                $"can be claimed for this role.",
                Intro = $"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Visit the client",
                        Detail = $"Meet up as agreed and have a lovely time - for the first visit, make sure you take along your ID badge or a letter from Age Connects explaining who you are"
                    },
                    new Step()
                    {
                        Heading = "Contact your volunteer manager",
                        Detail = $"Once you have completed your first visit, let us know by contacting your volunteer manager via email, phone or text. You will find their contact details listed as the ‘Requester’ on the accepted request."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"Only mark the request as complete when no more visits are required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support."
                    },
                    new Step()
                    {
                        Heading = "Share any concerns or updates",
                        Detail = $"Please make sure to tell us if you have any concerns about the client, or if they do not want the visits anymore. We would also just love to hear how you’re getting on!"
                    }
                },
                Close = "If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx)."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_Transport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_Transport,
                ActivityDetails = null,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = $"Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request."
                    },
                    new Step()
                    {
                        Heading = "Provide the transport",
                        Detail = $"Use the details given to you to pick up and drop off as required."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When you’re finished, mark the request as complete in “My Requests” - this will let us and " +
                        $"anyone else involved with the request know it’s been completed. You’ll still be able to find their contact " +
                        $"details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_PracticalSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_PracticalSupport,
                ActivityDetails = $"This client has been assessed as being isolated (little or no family support) and has requested some practical support. " +
                $"Expenses can be claimed for this role.",
                Intro = $"This role can be a range of different things such as form filling, helping someone do some research, assisting with telephone calls, teaching someone how to use their phone or tablet, changing a lightbulb or reading someone’s correspondence.",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Check what help is needed",
                        Detail = $"Make sure to read all of the information available on the open request (including clicking on the “More Info” link). Only accept the request if you’re able to provide the help that is needed."
                    },
                    new Step()
                    {
                        Heading = "Let the client know you’re able to help",
                        Detail = $"Contact the client to let them know who you are and to confirm the help is still needed. Arrange a convenient date and time to provide the help."
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = $"Provide the help that is needed."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"Once you have completed the task, mark it as complete from your “My Requests” page."
                    },
                    new Step()
                    {
                        Heading = "Share any concerns or updates",
                        Detail = $"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete."
                    }
                },
                Close = "If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx)."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_Prescriptions,
                ActivityDetails = $"This client has been assessed as being isolated (little or no family support) and has requested someone collect " +
                $"a prescription on their behalf. Most pharmacies will provide a delivery service for clients, so please explore with the client why " +
                $"they feel they need the help of a volunteer – it's possible they have not been able to get through on the phone or there is another " +
                $"issue that you can resolve for future prescriptions. If it is your first visit to a client, be prepared to introduce yourself – take " +
                $"along your ID badge or a letter from Age Connects explaining who you are. Expenses can be claimed for this role.",
                Intro = $"We are looking for you to pick up a prescription on a client’s behalf. (Prescriptions in Wales are free)",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Let the client know you’re able to help",
                        Detail = $"Contact the client to let them know who you are and to confirm the help is still needed. You should also check if the client has told the pharmacy that you will be picking up the prescription on their behalf - see the [NHS website](https://www.nhs.uk/common-health-questions/caring-carers-and-long-term-conditions/can-i-pick-up-a-prescription-for-someone-else/) for more details."
                    },
                    new Step()
                    {
                        Heading = "Collect the prescription",
                        Detail = $"Collect the prescription on the client’s behalf."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"Once you have completed the task, mark it as complete from your “My Requests” page."
                    },
                    new Step()
                    {
                        Heading = "Share any concerns or updates",
                        Detail = $"Please make sure to tell us if you have any concerns or updates by using the contact details provided on the request or leaving feedback when you mark the request as complete."
                    }
                },
                Close = "If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do” - this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx)."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_Other()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_Other,
                ActivityDetails = null,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = $"Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too."
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = $"Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When you’re finished, mark the request as complete in “My Requests” - this will let us and " +
                        $"anyone else involved with the request know it’s been completed. You’ll still be able to find their contact " +
                        $"details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_Shopping,
                ActivityDetails = $"This client has been assessed as being isolated (little or no family support) and has requested someone to shop for them. " +
                $"As a shopper you will be providing a shop and deliver service for the client either on a weekly or fortnightly basis. It could be that you are " +
                $"the only person they see or speak to that day, or even that week, and it can be an opportunity to provide the client with information about other " +
                $"services they may need. This is a fee-paying service, the client will pay £5 per shop. Expenses can be claimed for this role. Further guidance can " +
                $"be found when accepting the request, or in the ‘Volunteer Instructions’ section of the accepted request.",
                Intro = $"This platform was initially set up for one off requests and we are working on some changes which will make it easier to manage repeat requests. For now, please follow these instructions for providing help and marking a request as complete.",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Confirm the shopping list",
                        Detail = $"Contact the client to confirm what they need. Please read our [shopping guidance for Age Connects Volunteers](/pdf/ageconnectscardiff/shopping-guidance.pdf) for more detail about payment methods."
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = $"Carry out the shopping and deliver it back to them. If they need it, we would like you to help them put the shopping away."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"Only mark the request as complete when no more help is required. We expect to see the request as ‘In Progress’ for the duration of the ongoing support if you are helping with regular shopping."
                    },
                    new Step()
                    {
                        Heading = "Share any concerns or updates",
                        Detail = $"Please make sure to tell us if you have any concerns about the client, or if they do not want the shopping service any more."
                    }
                },
                Close = "If for any reason you can’t complete the request - or you need to stop making calls - let us know by updating the accepted request and clicking “Can’t Do”, this will allow us to find a new volunteer to help. If you need to claim expenses for this activity, you must do so within three months by submitting our [expense claim form](/forms/ageconnect/cardiff/volunteer-expense-form.docx)."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_VolunteerSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_VolunteerSupport,
                ActivityDetails = null,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = $"Make sure you’ve seen all the details by clicking the “View more info” link. If you’re able to help, click to accept the request."
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = $"Use the details given to you to carry out the request."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When you're finished, mark the request as complete in “My Requests”."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_VolunteerInduction()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeConnectCardiff_VolunteerInduction,
                ActivityDetails = null,
                Intro = "If you need to complete your volunteer induction training you can book on to this course.",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Book your place",
                        Detail = $"Accept this shift to book your place."
                    },
                    new Step()
                    {
                        Heading = "Attend the training",
                        Detail = $"Use the details provided to attend your training."
                    },
                    new Step()
                    {
                        Heading = "We’ll update your record",
                        Detail = $"Once you’ve completed your training we’ll update your record."
                    }
                },
                Close = "If for any reason you can’t attend the training you’ve selected, let us know by updating your shift and clicking “Can’t Do”. You can re-book onto any available training at any time."
            };
        }

        private static Instructions GetInstructions_HMS_BinDayAssistance()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.HMS_BinDayAssistance,
                ActivityDetails = null,
                Intro = "We are working on some changes which will make it easier to manage repeat requests, but for now please follow these instructions for providing help and marking a request as complete.",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Check how long the help is needed for",
                        Detail = $"You can find out more in the ‘More details’ section of the request. Some requests may be for one-off help, while others are for ongoing support."
                    },
                    new Step()
                    {
                        Heading = "Take out the bins",
                        Detail = $"When the help is needed, take out the bins. Make sure you take them out first thing " +
                        $"(or the night before) and bring them back in if required."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When the help is no longer needed, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNottsBalderton_DogWalking()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNottsBalderton_DogWalking,
                ActivityDetails = null,
                Intro = "Please follow these steps to complete this request. You can also find more guidance for dog walking volunteers [here](/pdf/notts/balderton/DogWalking.pdf).",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = $"Get in touch with the person who needs the help to confirm what they need. If someone else has requested the help on their behalf it may be useful to give them a call too."
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = $"Provide the help that’s needed."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."                        
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNottsNorthMuskham_DogWalking()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_DogWalking,
                ActivityDetails = null,
                Intro = "Please follow these steps to complete this request. You can also find more guidance for dog walking volunteers [here](/pdf/notts/northmuskham/DogWalking.pdf).",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = $"Get in touch with the person who needs the help to confirm what they need. If someone else has requested the help on their behalf it may be useful to give them a call too."
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = $"Provide the help that’s needed."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNottsBalderton_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNottsBalderton_Shopping,
                Intro = "Please follow these steps to complete this request. You can also find more guidance for shopping volunteers [here](/pdf/notts/balderton/Shopping.pdf).",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Confirm what they need and agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNottsBalderton_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNottsBalderton_Prescriptions,
                Intro = "Please follow these steps to complete this request. You can also find more guidance for prescription collection volunteers [here](/pdf/notts/balderton/PrescriptionCollection.pdf).",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNottsBalderton_FriendlyChat()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNottsBalderton_FriendlyChat,
                Intro = "Please follow these steps to complete this request. You can also find more guidance for telephone befriending [here](/pdf/notts/balderton/TelephoneBefriending.pdf).",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Give them a call",
                        Detail = "Be a friendly voice at the end of the phone and have a good chat.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNottsNorthMuskham_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_Shopping,
                Intro = "Please follow these steps to complete this request. You can also find more guidance for shopping volunteers [here](/pdf/notts/northmuskham/Shopping.pdf).",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Confirm what they need and agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Pick up their shopping and drop it off at their door. Make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their shopping."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNottsNorthMuskham_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_Prescriptions,
                Intro = "Please follow these steps to complete this request. You can also find more guidance for prescription collection volunteers [here](/pdf/notts/northmuskham/PrescriptionCollection.pdf).",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Confirm what they need. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their purchase."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNottsNorthMuskham_FriendlyChat()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_FriendlyChat,
                Intro = "Please follow these steps to complete this request. You can also find more guidance for telephone befriending [here](/pdf/notts/northmuskham/TelephoneBefriending.pdf).",
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Give them a call",
                        Detail = "Be a friendly voice at the end of the phone and have a good chat.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_MansfieldCVS_VaccineSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.MansfieldCVS_VaccineSupport,
                ActivityDetails = $"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. " +
                $"Duties may vary by location and could include a range of indoor or outdoor activities, " +
                $"such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site," +
                $" general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept " +
                $"this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the " +
                $"shift or by clicking “View more info” on accepted shifts in the “My Shifts” tab.",
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Check the request details",
                        Detail = $"Please read the [role description and useful information](/pdf/mansfield-cvs/nottinghamshire-vaccine-support-information.pdf) " +
                        $"attachment for full details of the role. " +
                        $"Volunteers may also be asked to participate in regular lateral flow testing, you can find more information [here](/pdf/mansfield-cvs/lateral-flow-testing-for-vaccination-support-volunteers.pdf)."

                    },
                    new Step()
                    {
                        Heading = "Attending your shift",
                        Detail = $"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather " +
                        $"(e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the " +
                        $"details in the “My Shifts” tab but searching for shifts with the status “Done”."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer."
            };
        }

        private static Instructions GetInstructions_EastLindsey_VaccineSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.EastLindsey_VaccineSupport,
                ActivityDetails = $"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination " +
                $"centres. Duties may vary by location and could include a range of indoor or outdoor activities, such as: helping patients find " +
                $"their way around the vaccination centre, providing assistance and reassurance to patients while they are on site, general domestic " +
                $"duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist " +
                $"skills to accept this role and basic training will be provided on the day.",
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Check the request details",
                        Detail = $"Take a look at the request details for more information about what you may be asked to do on the day. " +
                        $"Volunteers may also be asked to participate in regular lateral flow testing, you can find more information " +
                        $"[here](/pdf/east_lindsey/lateral-flow-testing-for-vaccination-support-volunteers.pdf)."
                    },
                    new Step()
                    {
                        Heading = "Attending your shift",
                        Detail = $"You’ll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather " +
                        $"(e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the " +
                        $"details in the “My Shifts” tab but searching for shifts with the status “Done”."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know as soon as possible by updating the accepted request and clicking “Can’t Do” so we can find another volunteer."
            };
        }

        private static Instructions GetInstructions_ApexBank_StaffVaccinator()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.APEXBank_BankStaffVaccinator,
                ActivityDetails = $"This is a paid role. Registered vaccinators are required for the local COVID-19 vaccination site at " +
                $"Ruston Sports and Social Club, Lincoln. Patients from all five APEX PCN member practices attend the site which has a " +
                $"current footfall in excess of 1301 patients per day. " +
                $"We run two four - hour shifts per day. Vaccinators are welcome to book onto a morning and an afternoon shift on the same day. " +
                $"Before you first shift you will be offered a full induction supported by the centre manager, current vaccinators and advanced practitioners.",
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Accept the shift",
                        Detail = $"To book onto a shift simply click the green button below. We run two shifts per day " +
                        $"and welcome staff wishing to book onto both shifts. You will find all our open shifts in 'Open Shifts'.",
                    },
                    new Step()
                    {
                        Heading = "Attending your shift",
                        Detail = $"You'll receive a reminder email the day before your shift. Once you've completed a shift " +
                        $"it will be marked as complete automatically, but you can still view a completed shift by selecting " +
                        $"shifts with the status 'Done' in 'My Shifts'."
                    }
                },
                Close = $"If for any reason you can't complete a shift please let us know as soon as possible by clicking “Can’t Do” on the accepted request. " +
                $"On rare occasions we may need to cancel a shift at short notice, where this is the case we will update you by email and endeavour " +
                $"to contact you using the details provided in your profile."
            };
        }

        private static Instructions GetInstructions_Southwell_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.Southwell_Prescriptions,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = "Confirm when the prescription will be ready and when you will deliver. Check if there will be a charge for anything, and if needed agree how it will be paid for. You can find out more about secure payment methods in our [FAQs](/questions#5). If someone else has requested the help on their behalf it may be useful to give them a call too.",
                    },
                    new Step()
                    {
                        Heading = "Provide help",
                        Detail = "Provide the help they need. If you do have to pay for something on their behalf, make sure you keep a copy of the receipt (e.g. by taking a photo) and give them the original along with their prescription.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail  = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”. In the event that the prescription is not available for delivery please inform the requester/client and rearrange delivery if possible. If you are unable to do delivery at another time remember to mark as “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_UKRANIAN_Accomodation()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.UKRANIAN_Accomodation,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Make sure you’ve found an appropriate match",
                        Detail = "Make sure you have read all of the information available and are happy that you can provide suitable accommodation for the person(s) requesting help.",
                    },
                    new Step()
                    {
                        Heading = "Click to ‘Accept’",
                        Detail = "If you’re happy you’ll provide a good match, click to accept the request. Please only accept one request for each property / room you have available - if you accept multiple requests you may make the process slower for the person(s) requesting help.",
                    },
                    new Step()
                    {
                        Heading = "Contact the request coordinator",
                        Detail  = "Use the details in the ‘My requests’ section of your profile to contact the request coordinator who will be able to provide more information. If your match is accepted they will also be able to provide the details of the person(s) requesting help."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail  = "Let us know when the person(s) you’re helping have moved in by marking the request as complete in “My Requests”."
                    }
                },
                Close = "If for any reason you can’t complete the request, let us know by updating the accepted request and clicking “Can’t Do”. This will automatically notify everyone involved in the request for you."
            };
        }



        private static Instructions GetInstructions_AgeUK_MidMersey_Befriending()
        {
            return new Instructions()
            {
                SupportActivityInstructions = SupportActivityInstructionsEnum.AgeUKMidMersey_Befriending,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Arrange a visit",
                        Detail = "Give them a call to arrange a visit – find a time and a place that suits you both.",
                    },
                    new Step()
                    {
                        Heading = "Enjoy your visit",
                        Detail = "Meet up as agreed and have a good chat. If it’s going well, you could arrange your next visit too!",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail  = "When you're finished, mark the request as complete in “My Accepted Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Complete Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        public static void PopulateSupportActivityInstructions(this EntityTypeBuilder<EntityFramework.Entities.SupportActivityInstructions> entity)
        {
            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsShopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_OtherPurchase,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsOtherPurchase())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_General,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsGeneral())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_FriendlyChat,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsFriendlyChat())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_Homework,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsHomework())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_CheckIn,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsCheckIn())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_FaceCovering,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsFaceCovering())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.FTLOS_FaceCovering,
                Instructions = JsonConvert.SerializeObject(GetInstructions_FtlosFaceCovering())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKLincoln_V4V,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKLincoln_V4V())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKWirral_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKWirral_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKWirral_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKWirral_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKWirral_VolunteerSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKWirral_VolunteerSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKWirral_General,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKWirral_General())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKLSL_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKLSL_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKLSL_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKLSL_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKLSL_General,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKLSL_General())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKSKC_MealtimeCompanion,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_MealtimeCompanion())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKSKC_MealsToYourDoor,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_MealOnWheels())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_VolunteerSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HMS_VolunteerSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_EmergencySupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HMS_EmergencySupport())
            }); 

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKSKC_Other,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_Other())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKSKC_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKSKC_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNWK_Other,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNWK_Other())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNWK_MealsToYourDoor,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNWK_MealsToYourDoor())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNWK_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNWK_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNWK_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNWK_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKFANDS_FriendlyChat,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_FriendlyChat())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKFANDS_MealtimeCompanion,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_MealtimeCompanion())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKFANDS_MealsToYourDoor,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_MealsToYourDoor())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKFANDS_Transport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_Transport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKFANDS_VolunteerSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_VolunteerSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKFANDS_Other,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_Other())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.Lincoln_VaccineSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_LincolnVaccineSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.Lincoln_Stamford_VaccineSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_LincolnStamfordVaccineSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_InPersonBefriending,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_InPersonBefriending())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_FriendlyChat,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_FriendlyChat())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_Transport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_Transport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_PracticalSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_PracticalSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_VolunteerSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_VolunteerSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_Other,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_Other())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeConnectCardiff_VolunteerInduction,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_VolunteerInduction())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.HMS_BinDayAssistance,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HMS_BinDayAssistance())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNottsBalderton_DogWalking,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNottsBalderton_DogWalking())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_DogWalking,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNottsNorthMuskham_DogWalking())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNottsBalderton_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNottsBalderton_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNottsBalderton_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNottsBalderton_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNottsBalderton_FriendlyChat,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNottsBalderton_FriendlyChat())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNottsNorthMuskham_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNottsNorthMuskham_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_FriendlyChat,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNottsNorthMuskham_FriendlyChat())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.MansfieldCVS_VaccineSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_MansfieldCVS_VaccineSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.EastLindsey_VaccineSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_EastLindsey_VaccineSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.APEXBank_BankStaffVaccinator,
                Instructions = JsonConvert.SerializeObject(GetInstructions_ApexBank_StaffVaccinator())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.Southwell_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_Southwell_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.AgeUKMidMersey_Befriending,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUK_MidMersey_Befriending())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.UKRANIAN_Accomodation,
                Instructions = JsonConvert.SerializeObject(GetInstructions_UKRANIAN_Accomodation())
            });


        }


        private static void Populate(EntityTypeBuilder<GroupSupportActivityConfiguration> entity, Groups group, SupportActivities activity, SupportActivityInstructionsEnum instructions, double radius = 20d)
        {
            entity.HasData(new GroupSupportActivityConfiguration()
            {
                SupportActivityId = (int)activity,
                GroupId = (int)group,
                SupportActivityInstructionsId = (short)instructions,
                Radius = radius
            });
        }

        public static void PopulateGroupSupportActivityInstructions(this EntityTypeBuilder<GroupSupportActivityConfiguration> entity)
        {
            Populate(entity, Groups.Generic, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn);
            Populate(entity, Groups.Generic, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Generic, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Generic, SupportActivities.FaceMask, SupportActivityInstructionsEnum.HMS_FaceCovering, NATIONAL_RADIUS);
            Populate(entity, Groups.Generic, SupportActivities.HomeworkSupport, SupportActivityInstructionsEnum.HMS_Homework, NATIONAL_RADIUS);
            Populate(entity, Groups.Generic, SupportActivities.MealPreparation, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.Generic, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Generic, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.Generic, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);

            Populate(entity, Groups.AgeUKLSL, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKLSL_Prescriptions);
            Populate(entity, Groups.AgeUKLSL, SupportActivities.Errands, SupportActivityInstructionsEnum.AgeUKLSL_General);
            Populate(entity, Groups.AgeUKLSL, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKLSL_General);
            Populate(entity, Groups.AgeUKLSL, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKLSL_Shopping);
            Populate(entity, Groups.AgeUKLSL, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);
            Populate(entity, Groups.AgeUKLSL, SupportActivities.WellbeingPackage, SupportActivityInstructionsEnum.AgeUKLincoln_V4V);

            Populate(entity, Groups.AgeUKWirral, SupportActivities.ColdWeatherArmy, SupportActivityInstructionsEnum.AgeUKWirral_General);
            Populate(entity, Groups.AgeUKWirral, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKWirral_Prescriptions);
            Populate(entity, Groups.AgeUKWirral, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKWirral_General);
            Populate(entity, Groups.AgeUKWirral, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKWirral_Shopping);
            Populate(entity, Groups.AgeUKWirral, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.AgeUKWirral_VolunteerSupport);

            Populate(entity, Groups.FTLOS, SupportActivities.FaceMask, SupportActivityInstructionsEnum.FTLOS_FaceCovering, NATIONAL_RADIUS);

            Populate(entity, Groups.Ruddington, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn);
            Populate(entity, Groups.Ruddington, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Ruddington, SupportActivities.DogWalking, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.Ruddington, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Ruddington, SupportActivities.FaceMask, SupportActivityInstructionsEnum.HMS_FaceCovering, NATIONAL_RADIUS);
            Populate(entity, Groups.Ruddington, SupportActivities.MealPreparation, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.Ruddington, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Ruddington, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.Ruddington, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.Ruddington, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.Tankersley, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn);
            Populate(entity, Groups.Tankersley, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Tankersley, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Tankersley, SupportActivities.FaceMask, SupportActivityInstructionsEnum.HMS_FaceCovering, NATIONAL_RADIUS);
            Populate(entity, Groups.Tankersley, SupportActivities.HomeworkSupport, SupportActivityInstructionsEnum.HMS_Homework, NATIONAL_RADIUS);
            Populate(entity, Groups.Tankersley, SupportActivities.MealPreparation, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.Tankersley, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Tankersley, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.Tankersley, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);

            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.MealsToYourDoor, SupportActivityInstructionsEnum.AgeUKFANDS_MealsToYourDoor);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKFANDS_Other);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.AgeUKFANDS_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.Transport, SupportActivityInstructionsEnum.AgeUKFANDS_Transport);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.AgeUKFANDS_VolunteerSupport);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.MealtimeCompanion, SupportActivityInstructionsEnum.AgeUKFANDS_MealtimeCompanion);


            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.MealsToYourDoor, SupportActivityInstructionsEnum.AgeUKNWK_MealsToYourDoor);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKNWK_Other);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKNWK_Shopping);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKNWK_Prescriptions);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKNottsBalderton_Prescriptions);
            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.AgeUKNottsBalderton_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKNottsBalderton_Shopping);
            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.DogWalking, SupportActivityInstructionsEnum.AgeUKNottsBalderton_DogWalking);

            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_Prescriptions);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_Shopping);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.DogWalking, SupportActivityInstructionsEnum.AgeUKNottsNorthMuskham_DogWalking);

            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKSKC_Prescriptions);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.MealsToYourDoor, SupportActivityInstructionsEnum.AgeUKSKC_MealsToYourDoor);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.MealtimeCompanion, SupportActivityInstructionsEnum.AgeUKSKC_MealtimeCompanion);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKSKC_Other);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKSKC_Shopping);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.LincolnPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.EastLindseyPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.EastLindsey_VaccineSupport);
            Populate(entity, Groups.StamfordPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_Stamford_VaccineSupport);

            Populate(entity, Groups.LincolnshireVolunteers, SupportActivities.EmergencySupport, SupportActivityInstructionsEnum.HMS_EmergencySupport);
            Populate(entity, Groups.LincolnshireVolunteers, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.Sandbox, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.EmergencySupport, SupportActivityInstructionsEnum.HMS_EmergencySupport);
            Populate(entity, Groups.Sandbox, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.Sandbox, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.Sandbox, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.Sandbox, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.AgeConnectCardiff_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.InPersonBefriending, SupportActivityInstructionsEnum.AgeConnectCardiff_InPersonBefriending);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.Other, SupportActivityInstructionsEnum.AgeConnectCardiff_Other);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.PracticalSupport, SupportActivityInstructionsEnum.AgeConnectCardiff_PracticalSupport);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.VolunteerInduction, SupportActivityInstructionsEnum.AgeConnectCardiff_VolunteerInduction);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.AgeConnectCardiff_VolunteerSupport);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.Transport, SupportActivityInstructionsEnum.AgeConnectCardiff_Transport);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeConnectCardiff_Shopping);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeConnectCardiff_Prescriptions);

            Populate(entity, Groups.Southwell, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.Southwell, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.Southwell_Prescriptions);
            Populate(entity, Groups.Southwell, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);

            Populate(entity, Groups.ApexBankStaff, SupportActivities.BankStaffVaccinator, SupportActivityInstructionsEnum.APEXBank_BankStaffVaccinator, NATIONAL_RADIUS);
            Populate(entity, Groups.ApexBankStaff, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);

            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, 2000);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.InPersonBefriending, SupportActivityInstructionsEnum.AgeUKMidMersey_Befriending, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.BinDayAssistance, SupportActivityInstructionsEnum.HMS_General, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.ColdWeatherArmy, SupportActivityInstructionsEnum.HMS_General, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.Covid19Help, SupportActivityInstructionsEnum.HMS_General, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.DigitalSupport, SupportActivityInstructionsEnum.HMS_General, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.DogWalking, SupportActivityInstructionsEnum.HMS_General, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.PracticalSupport, SupportActivityInstructionsEnum.HMS_OtherPurchase, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.SkillShare, SupportActivityInstructionsEnum.HMS_VolunteerSupport, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport, 20);
            Populate(entity, Groups.AgeUKMidMersey, SupportActivities.WellbeingPackage, SupportActivityInstructionsEnum.HMS_VolunteerSupport, 20);

            Populate(entity, Groups.BostonGNS, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping, 20);
            Populate(entity, Groups.BostonGNS, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, 2000);
            Populate(entity, Groups.BostonGNS, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase, 20);
            Populate(entity, Groups.BostonGNS, SupportActivities.PracticalSupport, SupportActivityInstructionsEnum.HMS_OtherPurchase, 20);
            Populate(entity, Groups.BostonGNS, SupportActivities.DogWalking, SupportActivityInstructionsEnum.HMS_General, 20);
            Populate(entity, Groups.BostonGNS, SupportActivities.DigitalSupport, SupportActivityInstructionsEnum.HMS_General, 20);
            Populate(entity, Groups.BostonGNS, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase, 20);

            Populate(entity, Groups.UkraineRefugees, SupportActivities.Accommodation, SupportActivityInstructionsEnum.UKRANIAN_Accomodation, 100);
            Populate(entity, Groups.UkraineRefugees, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping, 20);
            Populate(entity, Groups.UkraineRefugees, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, 2000);
            Populate(entity, Groups.UkraineRefugees, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn, 20);
            Populate(entity, Groups.UkraineRefugees, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase, 20);

        }
    }
}
