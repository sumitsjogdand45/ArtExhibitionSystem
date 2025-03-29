using ArtExhibitionSystem.application.Interfaces;
using ArtExhibitionSystem.Infrastructure.Context;
using ArtExhibitionSystem.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArtExhibitionSystem.Infrastructure
{
    public static class InterfaceServiceRegistration
    {
        public static IServiceCollection AddInterfaceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ArtDBContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("ArtWebAPIConnString"));


            });
            services.AddScoped<IArtworkRepository, ArtworksRepository>();
            return services;

        }
    }
   
}