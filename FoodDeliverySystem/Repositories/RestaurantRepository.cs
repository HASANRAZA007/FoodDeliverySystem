using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Repositories.Interfaces;

namespace FoodDeliverySystem.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
