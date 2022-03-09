using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace _03.Infra.Extensions
{
    public static class ServiceRegistration
    {
        public static void RegisterInfraStructureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
