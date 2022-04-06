using _01.Domain.DTOs.Output;

namespace _04.ApplicationServices.Models
{
    public class GetCustomerWithAddressModel
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
