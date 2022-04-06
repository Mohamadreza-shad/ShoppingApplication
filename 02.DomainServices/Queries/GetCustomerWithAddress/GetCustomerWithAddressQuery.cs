using MediatR;

namespace _02.DomainServices.Queries.GetCustomerWithAddress
{
    public class GetCustomerWithAddressQuery : IRequest<GetCustomerWithAddressDto>
    {
        public Guid CustomerId { get; set; }
    }
}
