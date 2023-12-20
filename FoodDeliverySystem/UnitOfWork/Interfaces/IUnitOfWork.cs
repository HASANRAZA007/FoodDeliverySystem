using FoodDeliverySystem.Repositories;

namespace FoodDeliverySystem.UnitOfWork.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        CustomerRepository CustomerRepository { get; }
        OrderRepository OrderRepository { get; }
        MenuItemRepository MenuItemRepository { get; }  
        DeliveryDriverRepositoy DeliveryDriverRepositoy { get; }
        RestaurantRepository RestaurantRepository { get; }
        void Commit();
    }
}
