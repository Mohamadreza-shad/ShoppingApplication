using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;
using _01.Domain.Interfaces.Repos;
using _03.Infra.DataContext;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.Repositories
{
    public class OrderRepository : BaseRepository<Order, Guid>, IOrderRepository
    {
        private readonly ShoppingContext _context;
        private readonly IMapper _mapper;

        public OrderRepository(ShoppingContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OrderOutputDto> CreateOrder(OrderInputDto inputDto)
        {
            Order order = _mapper.Map<Order>(inputDto);
            Order orderToReturn = await AddAndSaveAsync(order);
            return _mapper.Map<OrderOutputDto>(orderToReturn);
        }

        public async Task DeleteOrder(Guid id)
        {
            Order order = await GetByIdAsync(id);
            await DeleteAndSaveAsync(order);
        }

        public Task<Order> GetByIdAsync(Guid id)
        {
            return _context.Order.FirstOrDefaultAsync(ord => ord.Id == id);
        }

        public async Task<OrderOutputDto> UpdateOrder(Guid id, OrderInputDto inputDto)
        {
            Order order = await GetByIdAsync(id);
            order = _mapper.Map<Order>(inputDto);
            Order orderToReturn = await UpdateAndSaveAsync(order);
            return _mapper.Map<OrderOutputDto>(orderToReturn);
        }
    }
}
