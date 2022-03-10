using _01.Domain.Enums;

namespace _01.Domain.DTOs.Output
{
    public class ProductOutputDto
    {
        public string Name { get; set; }
        public ProductSize Size { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
