using _01.Domain.Entities;
using _01.Domain.Interfaces.QueryServices;
using _03.Infra.DataContext;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.QueryServices
{
    public class OrderDetailQueryService : IOrderDetailQueryService
    {
        private readonly ShoppingContext _context;

        public OrderDetailQueryService(ShoppingContext context)
        {
            _context = context;
        }

        public async Task<OrderDetail> GetOrderDetailById(Guid id)
        {
            return await _context.OrderDetail.AsNoTracking().FirstOrDefaultAsync(ord => ord.Id == id);
        }

        public async Task<List<OrderDetail>> GetOrderDetails()
        {
            return await _context.OrderDetail.AsNoTracking().ToListAsync();
        }
    }
}
