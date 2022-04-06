using _01.Domain.Interfaces.QueryServices;
using _01.Domain.Interfaces.Repos;
using _03.Infra.QueryServices;
using _03.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace _03.Infra.Extensions
{
    public static class ServiceRegistration
    {
        public static IServiceCollection RegisterInfraStructureServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<ICustomerQueryService, CustomerQueryService>();
            services.AddScoped<IOrderDetailQueryService, OrderDetailQueryService>();
            services.AddScoped<IOrderQueryService, OrderQueryService>();
            services.AddScoped<IProductQueryService, ProductQueryService>();
            services.AddScoped<IShipperQueryService, ShipperQueryService>();

            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IShipperRepository, ShipperRepository>();
            return services;
        }
    }
}
