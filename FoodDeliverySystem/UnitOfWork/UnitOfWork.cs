using FoodDeliverySystem.Database;
using FoodDeliverySystem.Repositories;
using FoodDeliverySystem.UnitOfWork.Interfaces;

namespace FoodDeliverySystem.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FoodDeliveryDbContext _dbContext;
        public UnitOfWork(FoodDeliveryDbContext _dbContext,CustomerRepository _customerRepository,MenuItemRepository _menuItemRepository, OrderRepository _orderRepository, DeliveryDriverRepositoy _deliveryDriverRepositoy,RestaurantRepository _restaurantRepository)
        { 
            this.DeliveryDriverRepositoy = _deliveryDriverRepositoy;
            this.CustomerRepository = _customerRepository;
            this.MenuItemRepository = _menuItemRepository;
            this.OrderRepository = _orderRepository;
            this.RestaurantRepository = _restaurantRepository;
            this._dbContext = _dbContext;
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
