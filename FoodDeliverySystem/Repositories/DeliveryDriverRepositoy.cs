using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Repositories.Interfaces;

namespace FoodDeliverySystem.Repositories
{
    public class DeliveryDriverRepositoy : GenericRepository<DeliveryDriver>, IDeliveryDriverRepository
    {
        public DeliveryDriverRepositoy(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
