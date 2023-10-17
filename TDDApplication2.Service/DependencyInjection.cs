using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TDDApplication2.DataAccessLayer.AutomapperProfiles;
using TDDApplication2.Service.Services;
using TDDApplication2.Service.Services.Interfaces;

namespace TDDApplication2.Service;

public static class DependencyInjection
{
    public static void RegisterBLLDependencies(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddAutoMapper(typeof(AutoMapperProfiles));
        services.AddScoped<IUserService, UserService>();
        DataAccessLayer.DependencyInjection.RegisterDALDependencies(services, Configuration);
    }
}