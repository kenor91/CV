using Infrastructure.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class Dependency
    {
        public static IServiceCollection AddCvContext(this IServiceCollection services)
        {
            services.AddDbContext<CvContext>(opt => opt.UseInMemoryDatabase("TempCV").EnableSensitiveDataLogging(), ServiceLifetime.Singleton);
            return services;
        }
    }
}
