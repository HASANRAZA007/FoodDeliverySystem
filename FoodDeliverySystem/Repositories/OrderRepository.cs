using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;

namespace FoodDeliverySystem.Repositories
{
    public class OrderRepository:GenericRepository<Order>
    {
        public OrderRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {

        }
    }
}
