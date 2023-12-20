using System.ComponentModel.DataAnnotations;

namespace FoodDeliverySystem.DTOs
{
    public class RestaurantDTO
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Location { get; set; }
    }
}
