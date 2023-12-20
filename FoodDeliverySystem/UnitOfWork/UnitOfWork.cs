using FoodDeliverySystem.Database;
using FoodDeliverySystem.Repositories;
using FoodDeliverySystem.UnitOfWork.Interfaces;

namespace FoodDeliverySystem.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FoodDeliveryDbContext _dbContext;
        public UnitOfWork(FoodDeliveryDbContext dbContext,CustomerRepository customerRepository,MenuItemRepository menuItemRepository, OrderRepository orderRepository, DeliveryDriverRepositoy deliveryDriverRepositoy,RestaurantRepository restaurantRepository)
        { 
            this.DeliveryDriverRepositoy = deliveryDriverRepositoy;
            this.CustomerRepository = customerRepository;
            this.MenuItemRepository = menuItemRepository;
            this.OrderRepository = orderRepository;
            this.RestaurantRepository = restaurantRepository;
            this._dbContext = dbContext;
        }
        public CustomerRepository CustomerRepository { get; }

        public OrderRepository OrderRepository { get; }

        public MenuItemRepository MenuItemRepository { get; }

        public DeliveryDriverRepositoy DeliveryDriverRepositoy { get; }

        public RestaurantRepository RestaurantRepository { get; }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}
