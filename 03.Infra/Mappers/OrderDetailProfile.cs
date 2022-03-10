using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;
using AutoMapper;

namespace _03.Infra.Mappers
{
    public class OrderDetailProfile : Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<OrderDetailInputDto, OrderDetail>();
            CreateMap<OrderDetail, OrderDetailOutputDto>();
        }
    }
}
