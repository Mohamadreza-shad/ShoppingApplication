using _02.DomainServices.Queries.GetCustomerWithAddress;
using _04.ApplicationServices.Models;
using AutoMapper;

namespace _04.ApplicationServices.Mappers
{
    public class CustomerAddressProfile : Profile
    {
        public CustomerAddressProfile()
        {
            CreateMap<GetCustomerWithAddressDto, GetCustomerWithAddressModel>();
        }
    }
}
