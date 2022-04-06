using _04.ApplicationServices.Services.Implementation;
using _04.ApplicationServices.Services.Interfaces;

namespace _05.EndPoints.Configuration
{
    public static class EndpointServicesRegistrationExtension
    {
        public static IServiceCollection RegisterEndpointServices(this IServiceCollection services)
        {
            services.AddScoped<ICustomerService, CustomerService>();
            return services;    
        }
    }
}
