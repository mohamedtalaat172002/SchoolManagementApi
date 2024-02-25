using Microsoft.Extensions.DependencyInjection;
using School.Infrastructure.Abstracts;
using School.Infrastructure.Repositories;

namespace School.Infrastructure
{
    public static class ModeuleInfrastructureDependecies
    {
        public static IServiceCollection AddInfrastrucureDependecies(this IServiceCollection services)
        {
            services.AddTransient<IstudentRepository,StudentRepository>();    
            return services;
        }
    }
}
