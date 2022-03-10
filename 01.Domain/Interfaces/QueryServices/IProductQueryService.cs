using _01.Domain.Entities;

namespace _01.Domain.Interfaces.QueryServices
{
    public interface IProductQueryService
    {
        Task<Product> GetProductById(Guid id);
        Task<List<Product>> GetProducts();
    }
}
