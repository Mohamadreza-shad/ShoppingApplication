using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;
using AutoMapper;

namespace _03.Infra.Mappers
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductInputDto, Product>();
            CreateMap<Product, ProductOutputDto>();
        }
    }
}
