using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;
using _01.Domain.Interfaces.Repos;
using _03.Infra.DataContext;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Infra.Repositories
{
    internal class OrderDetailRepository : BaseRepository<OrderDetail, Guid>, IOrderDetailRepository
    {
        private readonly ShoppingContext _context;
        private readonly IMapper _mapper;

        public OrderDetailRepository(ShoppingContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<OrderDetailOutputDto> CreateOrderDetail(OrderDetailInputDto inputDto)
        {
            OrderDetail orderDetail = _mapper.Map<OrderDetail>(inputDto);
            OrderDetail orderDetailToReturn = await AddAndSaveAsync(orderDetail);
            return _mapper.Map<OrderDetailOutputDto>(orderDetailToReturn);
        }

        public async Task DeleteOrderDetail(Guid id)
        {
            OrderDetail orderDetail = await GetByIdAsync(id);
            await DeleteAndSaveAsync(orderDetail);
        }

        public async Task<OrderDetail> GetByIdAsync(Guid id)
        {
            return await _context.OrderDetail.FirstOrDefaultAsync(ord => ord.Id == id);
        }

        public async Task<OrderDetailOutputDto> UpdateOrderDetail(Guid id, OrderDetailInputDto inputDto)
        {
            OrderDetail orderDetail = await GetByIdAsync(id);
            orderDetail = _mapper.Map<OrderDetail>(orderDetail);
            OrderDetail orderDetailToReturn = await UpdateAndSaveAsync(orderDetail);
            return _mapper.Map<OrderDetailOutputDto>(orderDetailToReturn);
        }
    }
}
