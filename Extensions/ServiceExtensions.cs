using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebProjectAPI.DbContextLayer;
using WebProjectAPI.Entities.IdentityModel;

namespace WebProjectAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(
                    options => options.UseSqlServer(
                    config.GetConnectionString("LocalHost"),
                    providerOptions => providerOptions.EnableRetryOnFailure()));

            services.AddIdentity<AppUser, IdentityRole>()
                          .AddEntityFrameworkStores<AppDbContext>()
                          .AddDefaultTokenProviders();
        }
    }
}
