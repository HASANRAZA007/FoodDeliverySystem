using FoodDeliverySystem.Models.Utility;
using System.ComponentModel.DataAnnotations;

namespace FoodDeliverySystem.DTOs
{
    public class DeliverDriverDTO
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public VehicleType VehicleType { get; set; }
    }
}
