namespace _00.Tools.Exceptions
{
    public class Error
    {
        public int Id { get; set; }
        public string MessageEn { get; set; }
        public string MessageFa { get; set; }

        public static Error CUSTOMERNOTFOUND = new()
        {
            Id = 1,
            MessageEn = "Customer not found",
            MessageFa = "مشتری پیدا نشد"
        };

        public static Error PRODUCTNOTFOUND = new()
        {
            Id = 1,
            MessageEn = "Product not found",
            MessageFa = "محصول پیدا نشد"
        };
    }
}
