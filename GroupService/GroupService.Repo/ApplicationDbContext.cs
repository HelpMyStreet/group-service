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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
