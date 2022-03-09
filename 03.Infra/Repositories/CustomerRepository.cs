using _01.Domain.DTOs;
using _01.Domain.DTOs.Input;
using _01.Domain.Entities;
using _01.Domain.Interfaces.Repos;
using _03.Infra.DataContext;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace _03.Infra.Repositories
{
    public class CustomerRepository : BaseRepository<Customer,Guid>, ICustomerRepository    
    {
        private readonly ShoppingContext _context;
        private readonly IMapper _mapper;

        public CustomerRepository(ShoppingContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<CustomerOutputDto> CreateCustomer(CustomerInputDto inputDto)
        {
            Customer customer = _mapper.Map<Customer>(inputDto);
            Customer customerToReturn = await AddAsync(customer);
            return _mapper.Map<CustomerOutputDto>(customerToReturn);
        }

        public async Task DeleteCustomer(Guid customerId)
        {
            Customer customer = await GetByIdAsync(customerId);
            await Delete(customer);
        }

        public async Task<Customer> GetByIdAsync(Guid customerId)
        {
            return await _context.Customer.FirstOrDefaultAsync(cus => cus.Id == customerId);
        }

        public async Task<CustomerOutputDto> UpdateCustomer(Guid customerId, CustomerInputDto inputDto)
        {
            Customer customer = await GetByIdAsync(customerId);
            customer = _mapper.Map<Customer>(inputDto);
            Customer customerToReturn = await UpdateAsync(customer);
            
            return _mapper.Map<CustomerOutputDto>(customerToReturn);
        }
    }
}
