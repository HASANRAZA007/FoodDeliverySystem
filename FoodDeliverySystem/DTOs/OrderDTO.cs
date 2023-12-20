using System.ComponentModel.DataAnnotations;

namespace FoodDeliverySystem.DTOs
{
    public class OrderDTO
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public decimal TotalAmount { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }                                                               
    }
}
