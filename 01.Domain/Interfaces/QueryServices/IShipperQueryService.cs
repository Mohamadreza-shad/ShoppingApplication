using _01.Domain.Entities;

namespace _01.Domain.Interfaces.QueryServices
{
    public interface IShipperQueryService
    {
        Task<Shipper> GetShipperById(Guid id);
        Task<List<Shipper>> GetShippers();
    }
}
