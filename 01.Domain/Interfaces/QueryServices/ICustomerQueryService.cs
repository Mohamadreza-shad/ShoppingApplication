using _01.Domain.Entities;

namespace _01.Domain.Interfaces.QueryServices
{
    public interface ICustomerQueryService
    {
        Task<Customer> GetCustomerById(Guid id);
        Task<List<Customer>> GetCustomers();
    }
}
