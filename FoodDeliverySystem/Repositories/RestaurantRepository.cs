using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;

namespace FoodDeliverySystem.Repositories
{
    public class RestaurantRepository : GenericRepository<Restaurant>
    {
        public RestaurantRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
