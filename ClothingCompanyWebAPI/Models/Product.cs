namespace ClothingCompanyWebAPI.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }


        // Navigation Property:
        public ICollection<OrderProduct> OrdersProducts { get; set; }

    }
}
