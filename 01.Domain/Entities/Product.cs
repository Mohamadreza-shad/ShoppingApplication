using _01.Domain.Enums;

namespace _01.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public ProductSize Size { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
    }
}
