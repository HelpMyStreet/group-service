﻿using GroupService.Repo.EntityFramework.Entities;
using HelpMyStreet.Utils.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GroupService.Repo.Helpers
{
    public static class GroupRequestNotificationStrategyExtensions
    {
        public static void SetGroupRequestNotificationStrategyExtensions(this EntityTypeBuilder<GroupNewRequestNotificationStrategy> entity)
        {
            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Ruddington,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKLSL,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.FTLOS,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Tankersley,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKWirral,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKNottsBalderton,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Generic,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = 100
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKNorthWestKent,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKNottsNorthMuskham,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Sandbox,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeConnectsCardiff,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKFavershamAndSittingbourne,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKSouthKentCoast,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.ApexBankStaff,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.AgeUKMidMersey,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.Southwell,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.BostonGNS,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.LincolnshireVolunteers,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.UkraineRefugees,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = 0
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.NHSVRDemo,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.NottinghamshireCountyCouncil,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.NottinghamshireIntegratedCareBoard,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.LincolnshireVCS,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });

            entity.HasData(new GroupNewRequestNotificationStrategy
            {
                GroupId = (int)Groups.LincolnshireLCVS,
                NewRequestNotificationStrategyId = (int)NewRequestNotificationStrategy.ClosestNEligibleVolunteers,
                MaxVolunteer = int.MaxValue
            });
        }
    }
}