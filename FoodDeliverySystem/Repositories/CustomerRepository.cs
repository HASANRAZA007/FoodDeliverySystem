using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;

namespace FoodDeliverySystem.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>
    {
        public CustomerRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
