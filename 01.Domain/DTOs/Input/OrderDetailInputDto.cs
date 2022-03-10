namespace _01.Domain.DTOs.Input
{
    public class OrderDetailInputDto
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
