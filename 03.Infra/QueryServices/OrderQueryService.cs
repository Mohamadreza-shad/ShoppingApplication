using _01.Domain.Entities;
using _01.Domain.Interfaces.QueryServices;
using _03.Infra.DataContext;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.QueryServices
{
    public class OrderQueryService : IOrderQueryService
    {
        private readonly ShoppingContext _context;

        public OrderQueryService(ShoppingContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrderById(Guid id)
        {
            return await _context.Order.AsNoTracking().FirstOrDefaultAsync(ord => ord.Id == id);
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _context.Order.AsNoTracking().ToListAsync();
        }
    }
}
