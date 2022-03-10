using _01.Domain.Entities;
using _01.Domain.Interfaces.QueryServices;
using _03.Infra.DataContext;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.QueryServices
{
    public class ShipperQueryService : IShipperQueryService
    {
        private readonly ShoppingContext _context;

        public ShipperQueryService(ShoppingContext context)
        {
            _context = context;
        }

        public async Task<Shipper> GetShipperById(Guid id)
        {
            return await _context.Shipper
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(cus => cus.Id == id);
        }

        public async Task<List<Shipper>> GetShippers()
        {
            return await _context.Shipper
                                 .AsNoTracking()
                                 .ToListAsync();
        }
    }
}
