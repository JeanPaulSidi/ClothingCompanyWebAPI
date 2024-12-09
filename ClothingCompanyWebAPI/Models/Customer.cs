using System.ComponentModel.DataAnnotations;

namespace ClothingCompanyWebAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public DateTime CustomerBirthDate { get; set; }
        public string? CustomerEmail { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerCity { get; set; }

        [MaxLength(2), MinLength(2)]
        public string? CustomerState { get; set; }
        public string? CustomerZipCode { get; set; }


        // Navigation Property:
        public ICollection<Order> Orders { get; set; }

    }
}
