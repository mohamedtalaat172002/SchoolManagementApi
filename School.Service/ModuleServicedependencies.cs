using Microsoft.Extensions.DependencyInjection;
using School.Service.Abstracts;
using School.Service.Implemetation;

namespace School.Service
{
    public static class ModuleServicedependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentServices, StudentServices>();
            return services;
        }
    }
}
