namespace _01.Domain.Entities
{
    public class Address : BaseEntity
    {
        public string City { get; set; }
        public string Province { get; set; }
        public string Description { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
