using _01.Domain.Entities;
using _01.Domain.Interfaces.QueryServices;
using _03.Infra.DataContext;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.QueryServices
{
    public class CustomerQueryService : ICustomerQueryService
    {
        private readonly ShoppingContext _context;

        public CustomerQueryService(ShoppingContext context)
        {
            _context = context;
        }

        public async Task<Customer> GetCustomerById(Guid id)
        {
            return await _context.Customer
                                 .AsNoTracking()
                                 .Include(cus => cus.Addresses)
                                 .FirstOrDefaultAsync(cus => cus.Id == id);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _context.Customer
                                 .AsNoTracking()
                                 .Include(cus => cus.Addresses)
                                 .ToListAsync();
        }
    }
}
