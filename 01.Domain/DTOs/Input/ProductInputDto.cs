using _01.Domain.Enums;

namespace _01.Domain.DTOs.Input
{
    public class ProductInputDto
    {
        public string Name { get; set; }
        public ProductSize Size { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
