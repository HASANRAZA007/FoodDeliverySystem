using System.ComponentModel.DataAnnotations;

namespace FoodDeliverySystem.DTOs
{
    public class MenuItemDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int RestaurantId { get; set; }
    }
}
