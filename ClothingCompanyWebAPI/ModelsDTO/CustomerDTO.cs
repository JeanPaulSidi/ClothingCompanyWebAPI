using ClothingCompanyWebAPI.Models;

namespace ClothingCompanyWebAPI.ModelsDTO
{
    public class CustomerDTO
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string? CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
