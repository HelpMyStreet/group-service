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
        public static void SetEnumSupportActivityInstructionsExtensionsData(this EntityTypeBuilder<EnumSupportActivityInstructions> entity)
        {
            var supportActivityInstructions = Enum.GetValues(typeof(HelpMyStreet.Utils.Enums.SupportActivityInstructions)).Cast<HelpMyStreet.Utils.Enums.SupportActivityInstructions>();

            foreach (var instruction in supportActivityInstructions)
            {
                entity.HasData(new EnumSupportActivityInstructions { Id = (int)instruction, Name = instruction.ToString() });
            }
        }

        private static Instructions GetInstructions_HmsShopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_Shopping,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us and anyone else involved with the request know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsOtherPurchase()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_OtherPurchase,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsGeneral()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_General,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsFriendlyChat()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_FriendlyChat,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch. If someone else has requested the help on their behalf it may be useful to give them a call to let them know how it went.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsHomework()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_Homework,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due (including if you don’t know the answer!), let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsCheckIn()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_CheckIn,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HmsFaceCovering()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_FaceCovering,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_FtlosFaceCovering()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.FTLOS_FaceCovering,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKLincoln_V4V()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKLincoln_V4V,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing volunteering@ageuklsl.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKWirral_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKWirral_Shopping,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKWirral_General()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKWirral_General,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. You’ll still be able to find their contact details in “My Requests” in case you need to get back in touch.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKWirral_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKWirral_Prescriptions,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:H&Cadminteam@ageukwirral.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKLSL_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKLSL_Shopping,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKLSL_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKLSL_Prescriptions,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKLSL_General()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKLSL_General,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageuklsl.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_MealtimeCompanion()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_MealtimeCompanion,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk.",                        
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_MealOnWheels()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_MealsToYourDoor,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk."                        
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HMS_VolunteerSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_VolunteerSupport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the ‘View more info' link. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you're finished, mark the request as complete in “My Requests”.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_HMS_EmergencySupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_EmergencySupport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the ‘View more info' link. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request.",
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you're finished, mark the request as complete in “My Requests”.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNWK_Other()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKNWK_Other,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:contactus@ageuknorthwestkent.org.uk.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_Other()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_Other,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk ."
                   }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_Prescriptions,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKSKC_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_Shopping,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:volunteering@ageukskc.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNWK_MealsToYourDoor()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKNWK_MealsToYourDoor,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNWK_Prescriptions()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKNWK_Prescriptions,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:contactus@ageuknorthwestkent.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKNWK_Shopping()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKNWK_Shopping,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person you visited let us know immediately by emailing mailto:kirsty.groves@ageuknorthwestkent.org.uk."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_FriendlyChat()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_FriendlyChat,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests” - this will let us " +
                        "(and anyone else involved with the request) know it's been completed. You’ll still be able to find their " +
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
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_MealtimeCompanion,
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
                        Detail = "When you're home, mark the request as complete in “My Requests”. If you have any concerns " +
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
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_MealsToYourDoor,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the " +
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
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_Transport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the transport",
                        Detail = "Use the details given to you to pick up and drop off as required."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you're finished, mark the request as complete in “My Requests”.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_VolunteerSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_VolunteerSupport,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = "Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request.",
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = "Use the details given to you to carry out the request."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = "When you're finished, mark the request as complete in “My Requests”.",
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeUKFANDS_Other()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_Other,
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
                        Detail = "When you're finished, mark the request as complete in “My Requests”. If you have any concerns about the person " +
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
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.Lincoln_VaccineSupport,
                ActivityDetails = $"Vaccination programme support volunteers are needed to help things run smoothly at local COVID-19 vaccination centres. " +
                $"Duties may vary by location and could include a range of indoor or outdoor activities, " +
                $"such as: helping patients find their way around the vaccination centre, providing assistance and reassurance to patients while they are on site," +
                $" general domestic duties (e.g. wiping down furniture and restocking sanitisation stations). You do not need a clinical background or any specialist skills to accept " +
                $"this role and basic training will be provided on the day. For a fuller description please see the volunteer instructions which are available when you click to accept the " +
                $"shift or by clicking ‘View more info’ on accepted shifts in the “My Shifts” tab.",
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Check the request details",
                        Detail = $"Please read the [role description and useful information](/pdf/lincs-vaccination-support/lincs-vaccination-support-role-description.pdf) " +
                        $"attachment for full details of the role."
                    },
                    new Step()
                    {
                        Heading = "Attending your shift",
                        Detail = $"You'll receive a reminder email the day before your shift. Make sure to bring a face covering and appropriate clothing for the weather " +
                        $"(e.g. a warm / waterproof coat). Once you’ve completed a shift it will be marked as complete automatically. You’ll still be able to find all the " +
                        $"details in the “My Shifts” tab but searching for shifts with the status “Done”."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_InPersonBefriending()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_InPersonBefriending,
                ActivityDetails = null,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Contact the requester",
                        Detail = $"Get in touch with the requester and arrange a convenient time an place to meet up."
                    },
                    new Step()
                    {
                        Heading = "Meet up",
                        Detail = $"Meet up as agreed and have a lovely time."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When you're finished, mark the request as complete in “My Requests” - this will let us and " +
                        $"anyone else involved with the request know it's been completed. You’ll still be able to find their contact " +
                        $"details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_Transport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_Transport,
                ActivityDetails = null,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = $"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request."
                    },
                    new Step()
                    {
                        Heading = "Provide the transport",
                        Detail = $"Use the details given to you to pick up and drop off as required."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When you're finished, mark the request as complete in “My Requests” - this will let us and " +
                        $"anyone else involved with the request know it's been completed. You’ll still be able to find their contact " +
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
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_PracticalSupport,
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
                        Detail = $"When you're finished, mark the request as complete in “My Requests” - this will let us and " +
                        $"anyone else involved with the request know it's been completed. You’ll still be able to find their contact " +
                        $"details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_Other()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_Other,
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
                        Detail = $"When you're finished, mark the request as complete in “My Requests” - this will let us and " +
                        $"anyone else involved with the request know it's been completed. You’ll still be able to find their contact " +
                        $"details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_VolunteerSupport()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_VolunteerSupport,
                ActivityDetails = null,
                Intro = null,
                Steps = new System.Collections.Generic.List<Step>()
                {
                    new Step()
                    {
                        Heading = "Find out what help is needed",
                        Detail = $"Make sure you’ve seen all the details by clicking the ‘View more info link’. If you’re able to help, click to accept the request."
                    },
                    new Step()
                    {
                        Heading = "Provide the help that is needed",
                        Detail = $"Use the details given to you to carry out the request."
                    },
                    new Step()
                    {
                        Heading = "Mark the request as complete",
                        Detail = $"When you're finished, mark the request as complete in “My Requests” - this will let us and " +
                        $"anyone else involved with the request know it's been completed. You’ll still be able to find their contact " +
                        $"details in “My Requests” in case you need to get back in touch."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        private static Instructions GetInstructions_AgeConnectCardiff_VolunteerInduction()
        {
            return new Instructions()
            {
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_VolunteerInduction,
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
                SupportActivityInstructions = HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_BinDayAssistance,
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
                        Detail = $"When the help is no longer needed, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it's been completed."
                    }
                },
                Close = "If for any reason you can’t complete the request before it’s due, let us know by updating the accepted request and clicking “Can’t Do”."
            };
        }

        public static void PopulateSupportActivityInstructions(this EntityTypeBuilder<EntityFramework.Entities.SupportActivityInstructions> entity)
        {
            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsShopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_OtherPurchase,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsOtherPurchase())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_General,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsGeneral())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_FriendlyChat,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsFriendlyChat())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_Homework,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsHomework())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_CheckIn,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsCheckIn())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_FaceCovering,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HmsFaceCovering())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.FTLOS_FaceCovering,
                Instructions = JsonConvert.SerializeObject(GetInstructions_FtlosFaceCovering())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKLincoln_V4V,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKLincoln_V4V())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKWirral_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKWirral_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKWirral_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKWirral_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKWirral_General,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKWirral_General())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKLSL_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKLSL_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKLSL_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKLSL_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKLSL_General,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKLSL_General())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_MealtimeCompanion,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_MealtimeCompanion())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_MealsToYourDoor,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_MealOnWheels())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_VolunteerSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HMS_VolunteerSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_EmergencySupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HMS_EmergencySupport())
            }); 

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_Other,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_Other())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKSKC_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKSKC_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKNWK_Other,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNWK_Other())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKNWK_MealsToYourDoor,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNWK_MealsToYourDoor())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKNWK_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNWK_Prescriptions())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKNWK_Shopping,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKNWK_Shopping())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_FriendlyChat,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_FriendlyChat())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_MealtimeCompanion,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_MealtimeCompanion())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_MealsToYourDoor,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_MealsToYourDoor())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_Transport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_Transport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_VolunteerSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_VolunteerSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeUKFANDS_Other,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeUKFANDS_Other())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.Lincoln_VaccineSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_LincolnVaccineSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_InPersonBefriending,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_InPersonBefriending())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_Transport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_Transport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_PracticalSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_PracticalSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_VolunteerSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_VolunteerSupport())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_Other,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_Other())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.AgeConnectCardiff_VolunteerInduction,
                Instructions = JsonConvert.SerializeObject(GetInstructions_AgeConnectCardiff_VolunteerInduction())
            });

            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)HelpMyStreet.Utils.Enums.SupportActivityInstructions.HMS_BinDayAssistance,
                Instructions = JsonConvert.SerializeObject(GetInstructions_HMS_BinDayAssistance())
            });
        }


        private static void Populate(EntityTypeBuilder<GroupSupportActivityInstructions> entity, Groups group, SupportActivities activity, SupportActivityInstructionsEnum instructions)
        {
            entity.HasData(new GroupSupportActivityInstructions()
            {
                SupportActivityId = (int)activity,
                GroupId = (int)group,
                SupportActivityInstructionsId = (short)instructions
            });
        }

        public static void PopulateGroupSupportActivityInstructions(this EntityTypeBuilder<GroupSupportActivityInstructions> entity)
        {
            Populate(entity, Groups.Generic, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn);
            Populate(entity, Groups.Generic, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Generic, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Generic, SupportActivities.FaceMask, SupportActivityInstructionsEnum.HMS_FaceCovering);
            Populate(entity, Groups.Generic, SupportActivities.HomeworkSupport, SupportActivityInstructionsEnum.HMS_Homework);
            Populate(entity, Groups.Generic, SupportActivities.MealPreparation, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.Generic, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Generic, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
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

            Populate(entity, Groups.FTLOS, SupportActivities.FaceMask, SupportActivityInstructionsEnum.FTLOS_FaceCovering);

            Populate(entity, Groups.Ruddington, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn);
            Populate(entity, Groups.Ruddington, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Ruddington, SupportActivities.DogWalking, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.Ruddington, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Ruddington, SupportActivities.FaceMask, SupportActivityInstructionsEnum.HMS_FaceCovering);
            Populate(entity, Groups.Ruddington, SupportActivities.MealPreparation, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.Ruddington, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Ruddington, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.Ruddington, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.Ruddington, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.Tankersley, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn);
            Populate(entity, Groups.Tankersley, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Tankersley, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Tankersley, SupportActivities.FaceMask, SupportActivityInstructionsEnum.HMS_FaceCovering);
            Populate(entity, Groups.Tankersley, SupportActivities.HomeworkSupport, SupportActivityInstructionsEnum.HMS_Homework);
            Populate(entity, Groups.Tankersley, SupportActivities.MealPreparation, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.Tankersley, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Tankersley, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.Tankersley, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);

            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.MealsToYourDoor, SupportActivityInstructionsEnum.AgeUKFANDS_MealsToYourDoor);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKFANDS_Other);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.AgeUKFANDS_FriendlyChat);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.Transport, SupportActivityInstructionsEnum.AgeUKFANDS_Transport);
            Populate(entity, Groups.AgeUKFavershamAndSittingbourne, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.AgeUKFANDS_VolunteerSupport);

            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.MealsToYourDoor, SupportActivityInstructionsEnum.AgeUKNWK_MealsToYourDoor);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKNWK_Other);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKNWK_Shopping);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKNWK_Prescriptions);
            Populate(entity, Groups.AgeUKNorthWestKent, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.AgeUKNottsBalderton, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);

            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.AgeUKNottsNorthMuskham, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);

            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKSKC_Prescriptions);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.MealsToYourDoor, SupportActivityInstructionsEnum.AgeUKSKC_MealsToYourDoor);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.MealtimeCompanion, SupportActivityInstructionsEnum.AgeUKSKC_MealtimeCompanion);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKSKC_Other);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKSKC_Shopping);
            Populate(entity, Groups.AgeUKSouthKentCoast, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.BostonPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.GranthamPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.LincolnPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.LincolnPortlandPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.LouthPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.SouthLincolnPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.SpilsbyPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.StamfordPCN, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);

            Populate(entity, Groups.LincolnshireVolunteers, SupportActivities.EmergencySupport, SupportActivityInstructionsEnum.HMS_EmergencySupport);
            Populate(entity, Groups.LincolnshireVolunteers, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.Sandbox, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.EmergencySupport, SupportActivityInstructionsEnum.HMS_EmergencySupport);
            Populate(entity, Groups.Sandbox, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.Sandbox, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.Sandbox, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.Sandbox, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);

            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.InPersonBefriending, SupportActivityInstructionsEnum.AgeConnectCardiff_InPersonBefriending);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.Other, SupportActivityInstructionsEnum.AgeConnectCardiff_Other);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.PracticalSupport, SupportActivityInstructionsEnum.AgeConnectCardiff_PracticalSupport);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.VolunteerInduction, SupportActivityInstructionsEnum.AgeConnectCardiff_VolunteerInduction);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.AgeConnectCardiff_VolunteerSupport);
            Populate(entity, Groups.AgeConnectsCardiff, SupportActivities.Transport, SupportActivityInstructionsEnum.AgeConnectCardiff_Transport);

            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.FaceMask, SupportActivityInstructionsEnum.HMS_FaceCovering);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.CheckingIn, SupportActivityInstructionsEnum.HMS_CheckIn);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.DigitalSupport, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.BinDayAssistance, SupportActivityInstructionsEnum.HMS_BinDayAssistance);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.Covid19Help, SupportActivityInstructionsEnum.HMS_General);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);
            Populate(entity, Groups.MeadowsCommunityHelpers, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
        }
    }
}
