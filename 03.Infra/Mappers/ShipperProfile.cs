using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;
using AutoMapper;

namespace _03.Infra.Mappers
{
    public class ShipperProfile : Profile
    {
        public ShipperProfile()
        {
            CreateMap<ShipperInputDto, Shipper>();
            CreateMap<Shipper, ShipperOutputDto>();
        }
    }
}
