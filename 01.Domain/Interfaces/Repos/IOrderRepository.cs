using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;

namespace _01.Domain.Interfaces.Repos
{
    public interface IOrderRepository
    {
        Task<OrderOutputDto> CreateOrder(OrderInputDto inputDto);
        Task<OrderOutputDto> UpdateOrder(Guid OrderId, OrderInputDto inputDto);
        Task DeleteOrder(Guid OrderId);
        Task<Order> GetByIdAsync(Guid OrderId);
    }
}
