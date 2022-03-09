namespace _01.Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }

        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public Guid ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
