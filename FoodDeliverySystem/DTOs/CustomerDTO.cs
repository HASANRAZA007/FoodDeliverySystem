using System.ComponentModel.DataAnnotations;

namespace FoodDeliverySystem.DTOs
{
    public class CustomerDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [MaxLength(11)]
        public long PhoneNumber { get; set; }
    }
}
