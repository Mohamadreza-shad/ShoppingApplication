using _00.Tools.ApiResponses;
using _00.Tools.Exceptions;
using _02.DomainServices.Queries.GetCustomerWithAddress;
using _04.ApplicationServices.Models;
using _04.ApplicationServices.Services.Interfaces;
using AutoMapper;
using MediatR;
using System.Net;

namespace _04.ApplicationServices.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CustomerService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<ApiResponseModel<GetCustomerWithAddressModel>> GetCustomerWithAddress(Guid customerId)
        {
            GetCustomerWithAddressQuery query = new() { CustomerId = customerId };

            GetCustomerWithAddressDto customerWithAddressDto = await _mediator.Send(query);

            return (customerWithAddressDto == null) ?
                new ApiResponseModel<GetCustomerWithAddressModel>
                {
                    Data = null,
                    Error = Error.CUSTOMERNOTFOUND,
                    HttpStatusCode = HttpStatusCode.NotFound,
                }
                :
                new ApiResponseModel<GetCustomerWithAddressModel>
                {
                    Data = _mapper.Map<GetCustomerWithAddressModel>(customerWithAddressDto),
                    Error = null,
                    HttpStatusCode = HttpStatusCode.OK,
                };
        }
    }
}

