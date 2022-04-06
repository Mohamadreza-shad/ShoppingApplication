using _01.Domain.Entities;
using _01.Domain.Interfaces.QueryServices;
using AutoMapper;
using MediatR;

namespace _02.DomainServices.Queries.GetCustomerWithAddress
{
    public class GetCustomerWithAddressQueryHandler : IRequestHandler<GetCustomerWithAddressQuery, GetCustomerWithAddressDto>
    {
        private readonly ICustomerQueryService _customerQueryService;
        private readonly IMapper _mapper;

        public GetCustomerWithAddressQueryHandler(ICustomerQueryService customerQueryService, IMapper mapper)
        {
            _customerQueryService = customerQueryService;
            _mapper = mapper;
        }

        public async Task<GetCustomerWithAddressDto> Handle(GetCustomerWithAddressQuery query, 
                                                        CancellationToken cancellationToken = default)
        {
            Customer customerWithAddress = await _customerQueryService.GetCustomerById(query.CustomerId);
            return _mapper.Map<GetCustomerWithAddressDto>(customerWithAddress);
        }
    }
}
