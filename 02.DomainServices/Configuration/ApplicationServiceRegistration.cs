using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace _02.DomainServices.Configuration
{
    public static class ApplicationServiceRegistrationExtension 
    {
        public static IServiceCollection RegisterDomainServiceExtension(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
            
        }
    }
}
