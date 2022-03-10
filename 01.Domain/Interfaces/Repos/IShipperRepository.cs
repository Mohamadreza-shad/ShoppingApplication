using _01.Domain.DTOs.Input;
using _01.Domain.DTOs.Output;
using _01.Domain.Entities;

namespace _01.Domain.Interfaces.Repos
{
    public interface IShipperRepository
    {
        Task<ShipperOutputDto> CreateShipperAsync(ShipperInputDto productInput);
        Task<ShipperOutputDto> UpdateShipperAsync(Guid id, ShipperInputDto productInput);
        Task DeleteShipperAsync(Guid id);
        Task<Shipper> GetShipperByIdAsync(Guid id);
    }
}
