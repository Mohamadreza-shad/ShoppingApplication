namespace _01.Domain.Entities
{
    public class Shipper : BaseEntity
    {
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }
}
