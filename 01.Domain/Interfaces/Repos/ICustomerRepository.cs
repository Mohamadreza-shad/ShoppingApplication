using _01.Domain.DTOs;
using _01.Domain.DTOs.Input;
using _01.Domain.Entities;

namespace _01.Domain.Interfaces.Repos
{
    public interface ICustomerRepository
    {
        Task<CustomerOutputDto> CreateCustomer(CustomerInputDto inputDto);
        Task<CustomerOutputDto> UpdateCustomer(Guid customerId, CustomerInputDto inputDto);
        Task DeleteCustomer(Guid customerId);
        Task<Customer> GetByIdAsync(Guid customerId);
    }
}
