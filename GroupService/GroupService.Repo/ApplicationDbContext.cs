using GroupService.Repo.EntityFramework.Entities;
using GroupService.Repo.Helpers;
using HelpMyStreet.Utils.Extensions;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
        }
    }
}
