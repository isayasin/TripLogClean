using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TripLogCleanServer.Domain.Repositories;
using TripLogCleanServer.Infrastructure.Context;
using TripLogCleanServer.Infrastructure.Repositories;

namespace TripLogCleanServer.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("SqlServer"));
        });

        services.AddScoped<ITagRepository, TagRepository>();
        services.AddScoped<ITripRepository, TripRepository>();
        services.AddScoped<ITripContentRepository, TripContentRepository>();

        return services;
    }
}
