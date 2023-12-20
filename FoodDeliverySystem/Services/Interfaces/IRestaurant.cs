using FoodDeliverySystem.DTOs;

namespace FoodDeliverySystem.Services.Interfaces
{
    public interface IRestaurant
    {
        RestaurantDTO AddResturant(RestaurantDTO restaurantDTO);
        RestaurantDTO GetResturant(int Id);
        void DeleteResturant(int Id);
        IEnumerable<RestaurantDTO> GetAllRestuarant();
        RestaurantDTO UpdateResturant(int Id,RestaurantDTO restaurantDTO);

    }
}
