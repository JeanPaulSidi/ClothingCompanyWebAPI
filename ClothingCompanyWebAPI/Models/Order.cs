namespace ClothingCompanyWebAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderTotalAmount { get; set; }


        // Navigation Properties :
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderProduct> OrdersProducts { get; set; }
    }
}
