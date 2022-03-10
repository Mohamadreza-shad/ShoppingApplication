using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;

namespace _01.Domain.Interfaces.Repos
{
    public interface IProductRepository
    {
        Task<ProductOutputDto> CreateProductAsync(ProductInputDto productInput);
        Task<ProductOutputDto> UpdateProductAsync(Guid id, ProductInputDto productInput);
        Task DeleteProductAsync(Guid id);
        Task<Product> GetProductByIdAsync(Guid id);
    }
}
