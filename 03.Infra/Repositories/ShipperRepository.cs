using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;
using _01.Domain.Interfaces.Repos;
using _03.Infra.DataContext;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.Repositories
{
    public class ShipperRepository : BaseRepository<Shipper, Guid>, IShipperRepository
    {
        private readonly ShoppingContext _context;
        private readonly IMapper _mapper;

        public ShipperRepository(ShoppingContext context,IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ShipperOutputDto> CreateShipperAsync(ShipperInputDto shipperInput)
        {
            Shipper shipper = _mapper.Map<Shipper>(shipperInput);
            Shipper shipperToReturn = await AddAndSaveAsync(shipper);
            return _mapper.Map<ShipperOutputDto>(shipperToReturn);
        }

        public async Task DeleteShipperAsync(Guid id)
        {
            Shipper shipper = await GetShipperByIdAsync(id);
            await DeleteAndSaveAsync(shipper);
        }

        public async Task<Shipper> GetShipperByIdAsync(Guid id)
        {
            return await _context.Shipper.FirstOrDefaultAsync(sh => sh.Id == id);
        }

        public async Task<ShipperOutputDto> UpdateShipperAsync(Guid id, ShipperInputDto shipperInput)
        {
            Shipper shipper = await GetShipperByIdAsync(id);
            shipper = _mapper.Map<Shipper>(shipperInput);
            Shipper shipperToReturn = await UpdateAndSaveAsync(shipper);
            return _mapper.Map<ShipperOutputDto>(shipperToReturn);
        }
    }
}
