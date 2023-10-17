using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TDDApplication2.DataAccessLayer.DataContext;
using TDDApplication2.DataAccessLayer.Repositories;
using TDDApplication2.DataAccessLayer.Repositories.Interfaces;

namespace TDDApplication2.DataAccessLayer
{
    public static class DependencyInjection
    {
        public static void RegisterDALDependencies(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
