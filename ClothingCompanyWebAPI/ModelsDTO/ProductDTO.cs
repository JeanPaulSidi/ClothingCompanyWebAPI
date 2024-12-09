namespace ClothingCompanyWebAPI.ModelsDTO
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductPrice { get; set; } // (String) Display Price in currency format
        public string ProductDescription { get; set; }

    }
}
