using GroupService.Repo.EntityFramework.Entities;
using GroupService.Repo.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using GroupService.Repo.Extensions;

namespace GroupService.Repo
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            SqlConnection conn = (SqlConnection)Database.GetDbConnection();
            conn.AddAzureToken();
        }

        public virtual DbSet<UserRoleAudit> UserRoleAudit { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<RegistrationJourney> RegistrationJourney { get; set; }
        public virtual DbSet<RequestHelpJourney> RequestHelpJourney { get; set; }
        public virtual DbSet<SecurityConfiguration> SecurityConfigurations { get; set; }
        public virtual DbSet<GroupNewRequestNotificationStrategy> GroupNewRequestNotificationStrategy { get; set; }
        public virtual DbSet<EnumRole> EnumRole { get; set; }
        public virtual DbSet<EnumLocation> EnumLocation { get; set; }
        public virtual DbSet<EnumTargetGroup> EnumTargetGroup { get; set; }
        public virtual DbSet<EnumRequestHelpFormVariant> EnumRequestHelpFormVariant { get; set; }
        public virtual DbSet<EnumRegistrationFormVariant> EnumRegistrationFormVariant { get; set; }
        public virtual DbSet<EnumCredentialTypes> EnumCredentialTypes { get; set; }
        public virtual DbSet<EnumSupportActivity> EnumSupportActivity { get; set; }
        public virtual DbSet<EnumSupportActivityInstructions> EnumSupportActivityInstructions { get; set; }
        public virtual DbSet<EnumNewRequestNotificationStrategy> EnumNewRequestNotificationStrategy { get; set; }
        public virtual DbSet<EnumCommunicationJobType> EnumCommunicationJobType { get; set; }

        public virtual DbSet<ActivityCredentialSet> ActivityCredentialSet { get; set; }
        public virtual DbSet<Credential> Credential { get; set; }
        public virtual DbSet<CredentialSet> CredentialSet { get; set; }
        public virtual DbSet<GroupCredential> GroupCredential { get; set; }
        public virtual DbSet<GroupLocation> GroupLocation { get; set; }
        public virtual DbSet<UserCredential> UserCredential { get; set; }
        public virtual DbSet<RequestorDetails> RequestorDetails { get; set; }
        public virtual DbSet<SupportActivityInstructions> SupportActivityInstructions { get; set; }
        public virtual DbSet<GroupSupportActivityInstructions> GroupSupportActivityInstructions { get; set; }
        public virtual DbSet<RegistrationFormSupportActivity> RegistrationFormSupportActivity { get; set; }
        public virtual DbSet<SupportActivityConfiguration> SupportActivityConfiguration { get; set; }
        public virtual DbSet<GroupEmailConfiguration> GroupEmailConfiguration { get; set; }
        public virtual DbSet<GroupMapDetails> GroupMapDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CredentialExtensions.InitialiseCredentialSets();
            SupportActivityConfigurationExtensions.InitialiseData();

            modelBuilder.Entity<RegistrationFormSupportActivity>(entity =>
            {
                entity.HasKey(e => new { e.RequestHelpFormVariantId, e.SupportActivityId });

                entity.ToTable("RegistrationFormSupportActivity", "Website");

                entity.Property(e => e.RequestHelpFormVariantId).HasColumnName("RequestHelpFormVariantID");

                entity.Property(e => e.SupportActivityId).HasColumnName("SupportActivityID");

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.SetRegistrationFormSupportActivitiesExtensionsData();
            });

            modelBuilder.Entity<SupportActivityConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.SupportActivityId });
                entity.ToTable("SupportActivity", "Configuration");

                entity.Property(e => e.SupportActivityId)
                    .HasColumnName("SupportActivityID")
                    .ValueGeneratedNever();

                entity.SetSupportActivityConfigurationExtensionsData();
            });

            modelBuilder.Entity<EnumCredentialTypes>(entity =>
            {
                entity.ToTable("CredentialTypes", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumCredentialTypesExtensionsData();
            });

            modelBuilder.Entity<EnumRegistrationFormVariant>(entity =>
            {
                entity.ToTable("RegistrationFormVariant", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumRequestHelpFormVariantExtensionsData();
            });

            modelBuilder.Entity<EnumRequestHelpFormVariant>(entity =>
            {
                entity.ToTable("RequestHelpFormVariant", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumRequestHelpFormVariantExtensionsData();
            });

            modelBuilder.Entity<EnumRole>(entity =>
            {
                entity.ToTable("Role", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumRoleData();
            });

            modelBuilder.Entity<EnumLocation>(entity =>
            {
                entity.ToTable("Location", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumLocationData();
            });

            modelBuilder.Entity<EnumTargetGroup>(entity =>
            {
                entity.ToTable("TargetGroup", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumTargetGroupData();
            });

            modelBuilder.Entity<EnumSupportActivity>(entity =>
            {
                entity.ToTable("SupportActivity", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumSupportActivityExtensionsData();
            });

            modelBuilder.Entity<EnumSupportActivityInstructions>(entity =>
            {
                entity.ToTable("SupportActivityInstructions", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumSupportActivityInstructionsExtensionsData();
            });

            modelBuilder.Entity<EnumNewRequestNotificationStrategy>(entity =>
            {
                entity.ToTable("NewRequestNotificationStrategy", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumStrategyData();
            });

            modelBuilder.Entity<EnumCommunicationJobType>(entity =>
            {
                entity.ToTable("CommunicationJobType", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetCommunicationJobData();
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("Group", "Group");

                entity.HasIndex(e => e.GroupKey)
                    .HasName("UC_GroupKey")
                    .IsUnique();

                entity.HasIndex(e => e.GroupName)
                    .HasName("UC_GroupName")
                    .IsUnique();

                entity.SetDefaultGroup();

                entity.HasIndex(e => e.ParentGroupId);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ParentGroup)
                    .WithMany(p => p.InverseParentGroup)
                    .HasForeignKey(d => d.ParentGroupId);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId, e.RoleId });

                entity.ToTable("UserRole", "Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Role_Group");
            });

            modelBuilder.Entity<UserRoleAudit>(entity =>
            {
                entity.ToTable("UserRoleAudit", "Group");

                entity.HasIndex(e => e.GroupId);

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.AuthorisedByUserId).HasColumnName("AuthorisedByUserID");

                entity.Property(e => e.DateRequested).HasColumnType("datetime");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<RegistrationJourney>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.Source });

                entity.ToTable("RegistrationJourney", "Website");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.RegistrationJourney();

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RegistrationFormVariant).HasColumnName("RegistrationFormVariant");

                entity.Property(e => e.TargetGroups).HasColumnName("TargetGroups");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.RegistrationJourney)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegistrationJourney_Group");
            });

            modelBuilder.Entity<RequestHelpJourney>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.Source });

                entity.ToTable("RequestHelpJourney", "Website");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.RequestHelpJourney();

                entity.Property(e => e.Source)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RequestHelpFormVariant).HasColumnName("RequestHelpFormVariant");

                entity.Property(e => e.TargetGroups).HasColumnName("TargetGroups");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.RequestHelpJourney)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestHelpJourney_Group");
            });

            modelBuilder.Entity<SecurityConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.GroupId });

                entity.ToTable("SecurityConfiguration", "Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.AllowAutonomousJoinersAndLeavers).HasColumnName("AllowAutonomousJoinersAndLeavers")
                                                .HasColumnType("bit").IsRequired(true);

                entity.SetDefaultSecurityConfiguration();

                entity.HasOne(d => d.Group)
                    .WithOne(p => p.SecurityConfiguration)
                    .HasForeignKey<SecurityConfiguration>(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SecurityConfiguration_Group");
            });

            modelBuilder.Entity<GroupNewRequestNotificationStrategy>(entity =>
            {
                entity.HasKey(e => new { e.GroupId });

                entity.ToTable("NewRequestNotificationStrategy", "Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.SetGroupRequestNotificationStrategyExtensions();

                entity.HasOne(d => d.Group)
                    .WithOne(p => p.NewRequestNotificationStrategy)
                    .HasForeignKey<GroupNewRequestNotificationStrategy>(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewRequestNotificationStrategy_Group");
            });

            modelBuilder.Entity<ActivityCredentialSet>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.ActivityId, e.CredentialSetId });

                entity.ToTable("ActivityCredentialSet", "Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.CredentialSetId).HasColumnName("CredentialSetID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.ActivityCredentialSet)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityCredentialSet_GroupID");

                entity.SetActivityCredentialSet();
            });

            modelBuilder.Entity<Credential>(entity =>
            {
                entity.ToTable("Credential", "Group");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.SetCredentials();
            });

            modelBuilder.Entity<GroupCredential>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.CredentialId })
                    .HasName("PK_GROUP_CREDENTIAL");

                entity.ToTable("GroupCredential", "Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.CredentialId).HasColumnName("CredentialID");

                entity.Property(e => e.CredentialTypeId).HasColumnName("CredentialTypeID");

                entity.Property(e => e.HowToAchieve)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.HowToAchieve_CTA_Destination)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WhatIsThis)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Credential)
                    .WithMany(p => p.GroupCredential)
                    .HasForeignKey(d => d.CredentialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupCredential_CredentialID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupCredential)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupCredential_Group");

                entity.SetGroupCredentials();
            });

            modelBuilder.Entity<CredentialSet>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.GroupId, e.CredentialId });

                entity.ToTable("CredentialSet", "Group");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.CredentialId).HasColumnName("CredentialID");

                entity.HasOne(d => d.GroupCredential)
                    .WithMany(p => p.CredentialSet)
                    .HasForeignKey(d => new { d.GroupId, d.CredentialId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CredentialSet_CredentialID");

                entity.SetCredentialSet();
            });

            modelBuilder.Entity<GroupLocation>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.LocationId })
                    .HasName("PK_GROUP_LOCATION");

                entity.ToTable("GroupLocation", "Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupLocation)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupLocation_Group");

                entity.SetGroupLocationsConfiguration();
            });

            modelBuilder.Entity<UserCredential>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UserId, e.CredentialId, e.DateAdded });

                entity.ToTable("UserCredential", "Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.CredentialId).HasColumnName("CredentialID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AuthorisedByUserId).HasColumnName("AuthorisedByUserID");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValidUntil).HasColumnType("datetime");

                entity.HasOne(d => d.GroupCredential)
                    .WithMany(p => p.UserCredential)
                    .HasForeignKey(d => new { d.GroupId, d.CredentialId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserCredential_CredentialID");
            });

            modelBuilder.Entity<RequestorDetails>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("RequestorDetails", "Group");

                entity.Property(e => e.GroupId).ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AddressLine3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Locality)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MobilePhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtherPhone)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Group)
                    .WithOne(p => p.RequestorDetails)
                    .HasForeignKey<RequestorDetails>(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.RequestorDetails();
            });

            modelBuilder.Entity<GroupSupportActivityInstructions>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.SupportActivityId });

                entity.ToTable("GroupSupportActivityInstructions", "Group");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SupportActivityId).HasColumnName("SupportActivityID");

                entity.Property(e => e.SupportActivityInstructionsId).HasColumnName("SupportActivityInstructionsID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupSupportActivityInstructions)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupSupportActivityInstructions_GroupID");

                entity.HasOne(d => d.SupportActivityInstructions)
                    .WithMany(p => p.GroupSupportActivityInstructions)
                    .HasForeignKey(d => d.SupportActivityInstructionsId)
                    .HasConstraintName("FK_GroupSupportActivityInstructions_SupportActivityInstructionsID");

                entity.PopulateGroupSupportActivityInstructions();
            });

            modelBuilder.Entity<SupportActivityInstructions>(entity =>
            {
                entity.ToTable("SupportActivityInstructions", "Group");

                entity.Property(e => e.SupportActivityInstructionsId).HasColumnName("SupportActivityInstructionsID");

                entity.Property(e => e.Instructions)
                    .IsRequired()
                    .IsUnicode(false);

                entity.PopulateSupportActivityInstructions();
            });

            modelBuilder.Entity<GroupEmailConfiguration>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.CommunicationJobTypeId });

                entity.ToTable("GroupEmailConfiguration", "Group");

                entity.Property(e => e.GroupId)
                    .HasColumnName("GroupID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CommunicationJobTypeId).HasColumnName("CommunicationJobTypeID");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupEmailConfiguration)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupEmailConfiguration_GroupID");

                entity.PopulateGroupEmailConfiguration();
            });

            modelBuilder.Entity<GroupMapDetails>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.MapLocationId })
                    .HasName("PK_GROUP_GROUP_MAP_DETAILS");

                entity.ToTable("GroupMapDetails", "Group");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.MapLocationId).HasColumnName("MapLocationID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.ZoomLevel).HasColumnType("decimal(9, 6)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupMapDetails)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GroupCredential_GroupMapDetails");

                entity.AddGroupMapDetails();
            });
        }
    }
}
