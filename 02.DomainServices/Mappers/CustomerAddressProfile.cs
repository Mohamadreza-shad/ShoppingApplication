using _00.Tools.DateTimeTools;
using _01.Domain.Entities;
using _02.DomainServices.Queries.GetCustomerWithAddress;
using AutoMapper;

namespace _02.DomainServices.Mappers
{
    internal class CustomerAddressProfile : Profile
    {
        public CustomerAddressProfile()
        {
            CreateMap<Customer, GetCustomerWithAddressDto>()
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName}, {src.LastName}"))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.NationalCode, opt => opt.MapFrom(src => src.NationalCode))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => src.DateOfBirth.CalculateAge()))
                .ForMember(dest => dest.Addresses, opt => opt.MapFrom(src => src.Addresses));
        }
    }
}
