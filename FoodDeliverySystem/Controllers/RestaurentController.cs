using FoodDeliverySystem.DTOs;
using FoodDeliverySystem.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliverySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurentController : ControllerBase
    {
        private readonly IRestaurant _restaurantService;
        public RestaurentController(IRestaurant restaurant) 
        {
            this._restaurantService = restaurant;
        }
        [HttpPost]
        public IActionResult AddRestaurent([FromBody] RestaurantDTO restaurantDTO)
        { 
          var Restaurent = _restaurantService.AddResturant(restaurantDTO);
            return Ok(Restaurent);

        }
    }
}
