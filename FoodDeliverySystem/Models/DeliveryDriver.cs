using FoodDeliverySystem.Models.Utility;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodDeliverySystem.Models
{
    public class DeliveryDriver
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeliveryDriverId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public VehicleType VehicleType { get; set; }
        public ICollection<Order> Deliveries { get; set; }
    }
}
