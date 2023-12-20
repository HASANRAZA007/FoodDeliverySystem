using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Repositories.Interfaces;

namespace FoodDeliverySystem.Repositories
{
    public class MenuItemRepository : GenericRepository<MenuItem>, IMenuItemRepository
    {
        public MenuItemRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
