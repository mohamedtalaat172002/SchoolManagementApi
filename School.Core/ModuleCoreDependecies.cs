using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace School.Core
{
    public static class ModuleCoreDependecies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            //register Mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //register AutoMapping
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;

        }

    }
}
