using _00.Tools.ApiResponses;
using _04.ApplicationServices.Models;
using _04.ApplicationServices.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace _05.EndPoints.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("{customerId}")]
        public async Task<ActionResult<GetCustomerWithAddressModel>> GetCustomerAsync([FromRoute] Guid customerId)
        {
            ApiResponseModel<GetCustomerWithAddressModel> apiResponseModel = 
                                                        await _customerService.GetCustomerWithAddress(customerId);

            return (apiResponseModel.HttpStatusCode == HttpStatusCode.OK) ?
                Ok(apiResponseModel.Data) :
                NotFound(apiResponseModel.Error);
        }
    }
}
