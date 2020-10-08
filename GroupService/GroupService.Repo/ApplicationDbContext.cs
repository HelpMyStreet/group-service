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

        public virtual DbSet<EnumRole> EnumRole { get; set; }
        public virtual DbSet<EnumTargetGroup> EnumTargetGroup { get; set; }
        public virtual DbSet<EnumRequestHelpFormVariant> EnumRequestHelpFormVariant { get; set; }
        public virtual DbSet<EnumRegistrationFormVariant> EnumRegistrationFormVariant { get; set; }
        public virtual DbSet<EnumCredentialTypes> EnumCredentialTypes { get; set; }

        public virtual DbSet<ActivityCredentialSet> ActivityCredentialSet { get; set; }
        public virtual DbSet<Credential> Credential { get; set; }
        public virtual DbSet<CredentialSet> CredentialSet { get; set; }
        public virtual DbSet<GroupCredential> GroupCredential { get; set; }
        public virtual DbSet<UserCredential> UserCredential { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CredentialExtensions.InitialiseCredentialSets();

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

            modelBuilder.Entity<EnumTargetGroup>(entity =>
            {
                entity.ToTable("TargetGroup", "Lookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.SetEnumTargetGroupData();
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
                    .HasMaxLength(200)
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
        }
    }
}
