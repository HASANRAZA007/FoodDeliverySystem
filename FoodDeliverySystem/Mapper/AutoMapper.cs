using AutoMapper;
using FoodDeliverySystem.DTOs;
using FoodDeliverySystem.Models;

namespace FoodDeliverySystem.Mapper
{
    public class AutoMapper:Profile
    {
        public AutoMapper() 
        { 
            CreateMap<Restaurant,RestaurantDTO>().ReverseMap();
            CreateMap<Order,OrderDTO>().ReverseMap();
            CreateMap<MenuItem,MenuItemDTO>().ReverseMap();
            CreateMap<Customer,CustomerDTO>().ReverseMap();
            CreateMap<DeliveryDriver,DeliverDriverDTO>().ReverseMap();
        }
    }
}
