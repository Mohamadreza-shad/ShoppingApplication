using _01.Domain.Entities;
using _01.Domain.Interfaces.QueryServices;
using _03.Infra.DataContext;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.QueryServices
{
    public class ProductQueryService : IProductQueryService
    {
        private readonly ShoppingContext _context;

        public ProductQueryService(ShoppingContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductById(Guid id)
        {
            return await _context.Product
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(cus => cus.Id == id);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Product
                                 .AsNoTracking()
                                 .ToListAsync();
        }
    }
}
