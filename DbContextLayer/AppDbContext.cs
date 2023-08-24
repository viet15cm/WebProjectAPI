using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using WebProjectAPI.Entities;
using WebProjectAPI.Entities.IdentityModel;

namespace WebProjectAPI.DbContextLayer
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        protected AppDbContext()
        {
        }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            foreach (var item in builder.Model.GetEntityTypes())
            {
                var tableName = item.GetTableName();

                if (tableName.StartsWith("AspNet"))
                {
                    item.SetTableName(tableName.Substring(6));
                }

            }

        }

       
    }
}
