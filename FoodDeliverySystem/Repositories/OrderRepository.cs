using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Repositories.Interfaces;

namespace FoodDeliverySystem.Repositories
{
    public class OrderRepository:GenericRepository<Order>, IOrderRespository
    {
        public OrderRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {

        }
    }
}
