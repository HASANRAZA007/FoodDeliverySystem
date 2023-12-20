using FoodDeliverySystem.Database;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Repositories.Interfaces;

namespace FoodDeliverySystem.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepositoy
    {
        public CustomerRepository(FoodDeliveryDbContext dbContext) : base(dbContext)
        {
        }
    }
}
