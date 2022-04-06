using _00.Tools.ApiResponses;
using _04.ApplicationServices.Models;

namespace _04.ApplicationServices.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<ApiResponseModel<GetCustomerWithAddressModel>> GetCustomerWithAddress(Guid customerId);
    }
}
