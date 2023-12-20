using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;

namespace FoodDeliverySystem.Repositories
{
    public class MenuItemRepository : GenericRepository<MenuItem>
    {
        public MenuItemRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
