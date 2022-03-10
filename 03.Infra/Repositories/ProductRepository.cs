using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;
using _01.Domain.Interfaces.Repos;
using _03.Infra.DataContext;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.Repositories
{
    public class ProductRepository : BaseRepository<Product,Guid>, IProductRepository
    {
        private readonly ShoppingContext _context;
        private readonly IMapper _mapper;

        public ProductRepository(ShoppingContext context,IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ProductOutputDto> CreateProductAsync(ProductInputDto productInput)
        {
            Product product = _mapper.Map<Product>(productInput);
            Product productToReturn = await AddAndSaveAsync(product);
            return _mapper.Map<ProductOutputDto>(productToReturn);
        }
        public async Task DeleteProductAsync(Guid id)
        {
            Product product = await GetProductByIdAsync(id);
            await DeleteAndSaveAsync(product);
        }
        public async Task<Product> GetProductByIdAsync(Guid id)
        {
            return await _context.Product.FirstOrDefaultAsync(xx => xx.Id == id);
        }
        public async Task<ProductOutputDto> UpdateProductAsync(Guid id, ProductInputDto productInput)
        {
            Product product = await GetProductByIdAsync(id);
            product = _mapper.Map<Product>(productInput);
            Product productToReturn = await UpdateAndSaveAsync(product);
            return _mapper.Map<ProductOutputDto>(productToReturn);
        }
    }
}
