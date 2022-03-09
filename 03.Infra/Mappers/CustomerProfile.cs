using _00.Tools.DateTimeTools;
using _01.Domain.DTOs;
using _01.Domain.DTOs.Input;
using _01.Domain.Entities;
using AutoMapper;

namespace _03.Infra.Mappers
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerOutputDto>()
                .ForMember(dest => dest.FullName, src => src.MapFrom(xx => $"{xx.FirstName}, {xx.LastName}"))
                .ForMember(dest => dest.Age, src => src.MapFrom(xx => xx.DateOfBirth.CalculateAge()));

            CreateMap<CustomerInputDto,Customer>();
        }
    }
}
