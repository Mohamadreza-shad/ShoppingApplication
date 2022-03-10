using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;
using AutoMapper;

namespace _03.Infra.Mappers
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderInputDto, Order>();

            CreateMap<Order, OrderOutputDto>()
                .ForMember(dest => dest.OrderDate, src => src.MapFrom(xx => xx.OrderDate.ToString()));
        }
    }
}
