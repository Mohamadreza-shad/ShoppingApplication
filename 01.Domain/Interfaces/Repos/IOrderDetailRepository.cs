using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;

namespace _01.Domain.Interfaces.Repos
{
    public interface IOrderDetailRepository
    {
        Task<OrderDetailOutputDto> CreateOrderDetail(OrderDetailInputDto inputDto);
        Task<OrderDetailOutputDto> UpdateOrderDetail(Guid id, OrderDetailInputDto inputDto);
        Task DeleteOrderDetail(Guid id);
        Task<OrderDetail> GetByIdAsync(Guid id);
    }
}
