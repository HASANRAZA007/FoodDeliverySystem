using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;

namespace FoodDeliverySystem.Repositories
{
    public class DeliveryDriverRepositoy : GenericRepository<DeliveryDriver>
    {
        public DeliveryDriverRepositoy(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
