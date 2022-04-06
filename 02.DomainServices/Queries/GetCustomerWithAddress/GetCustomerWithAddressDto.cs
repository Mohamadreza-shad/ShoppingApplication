using _01.Domain.DTOs.Output;
using _01.Domain.Entities;

namespace _02.DomainServices.Queries.GetCustomerWithAddress
{
    public class GetCustomerWithAddressDto
    {
        public Guid CustomerId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string NationalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<AddressOutPutDto> Addresses { get; set; }
    }
}
