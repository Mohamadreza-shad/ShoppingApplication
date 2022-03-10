using _01.Domain.Entities;

namespace _01.Domain.Interfaces.QueryServices
{
    public interface IOrderDetailQueryService
    {
        Task<OrderDetail> GetOrderDetailById(Guid id);
        Task<List<OrderDetail>> GetOrderDetails();
    }
}
