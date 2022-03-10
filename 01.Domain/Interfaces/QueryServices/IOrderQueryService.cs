using _01.Domain.Entities;

namespace _01.Domain.Interfaces.QueryServices
{
    public interface IOrderQueryService
    {
        Task<Order> GetOrderById(Guid id);
        Task<List<Order>> GetOrders();
    }
}
