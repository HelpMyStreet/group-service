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
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:practicalsupportteam@ageukwirral.org.uk.",
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
                        Detail = "When you’re finished, mark the request as complete in “My Requests” - this will let us (and anyone else involved with the request) know it’s been completed. If you have any concerns about the person you visited let us know immediately by emailing mailto:practicalsupportteam@ageukwirral.org.uk.",
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

        public static void PopulateSupportActivityInstructions(this EntityTypeBuilder<EntityFramework.Entities.SupportActivityInstructions> entity)
        {
            entity.HasData(new EntityFramework.Entities.SupportActivityInstructions
            {
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.Lincoln_VaccineSupport,
                Instructions = JsonConvert.SerializeObject(GetInstructions_LincolnVaccineSupport())
            });

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
                SupportActivityInstructionsId = (short)SupportActivityInstructionsEnum.Southwell_Prescriptions,
                Instructions = JsonConvert.SerializeObject(GetInstructions_Southwell_Prescriptions())
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

            Populate(entity, Groups.AgeUKWirral, SupportActivities.ColdWeatherArmy, SupportActivityInstructionsEnum.AgeUKWirral_General);
            Populate(entity, Groups.AgeUKWirral, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.AgeUKWirral_Prescriptions);
            Populate(entity, Groups.AgeUKWirral, SupportActivities.Other, SupportActivityInstructionsEnum.AgeUKWirral_General);
            Populate(entity, Groups.AgeUKWirral, SupportActivities.Shopping, SupportActivityInstructionsEnum.AgeUKWirral_Shopping);
            Populate(entity, Groups.AgeUKWirral, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.AgeUKWirral_VolunteerSupport);

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

            Populate(entity, Groups.Sandbox, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.EmergencySupport, SupportActivityInstructionsEnum.HMS_EmergencySupport);
            Populate(entity, Groups.Sandbox, SupportActivities.Errands, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);
            Populate(entity, Groups.Sandbox, SupportActivities.PhoneCalls_Friendly, SupportActivityInstructionsEnum.HMS_FriendlyChat, NATIONAL_RADIUS);
            Populate(entity, Groups.Sandbox, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.Sandbox, SupportActivities.VaccineSupport, SupportActivityInstructionsEnum.Lincoln_VaccineSupport);
            Populate(entity, Groups.Sandbox, SupportActivities.VolunteerSupport, SupportActivityInstructionsEnum.HMS_VolunteerSupport);
           
            Populate(entity, Groups.Southwell, SupportActivities.Shopping, SupportActivityInstructionsEnum.HMS_Shopping);
            Populate(entity, Groups.Southwell, SupportActivities.CollectingPrescriptions, SupportActivityInstructionsEnum.Southwell_Prescriptions);
            Populate(entity, Groups.Southwell, SupportActivities.Other, SupportActivityInstructionsEnum.HMS_OtherPurchase);                        
        }
    }
}
