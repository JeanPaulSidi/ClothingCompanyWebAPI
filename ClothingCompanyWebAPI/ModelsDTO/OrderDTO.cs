namespace ClothingCompanyWebAPI.ModelsDTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderTotalAmount { get; set; } // (String) Display Amount in currency format
        public int CustomerId { get; set; }
        

    }
}
