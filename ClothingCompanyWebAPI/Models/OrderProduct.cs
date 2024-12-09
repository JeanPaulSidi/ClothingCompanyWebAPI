namespace ClothingCompanyWebAPI.Models
{
    public class OrderProduct
    {
        public int OrderProductId { get; set; }
        public int QuantityProductOrdered { get; set; }


        // Navigation Properties:
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }

    }
}
