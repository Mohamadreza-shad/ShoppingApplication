using _04.ApplicationServices.Services.Implementation;
using _04.ApplicationServices.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace _04.ApplicationServices.Configuration
{
    public static class ApplicationServiceRegistrationExtension
    {
        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            return services;
        }
    }
}
