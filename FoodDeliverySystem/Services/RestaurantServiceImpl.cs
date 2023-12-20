using AutoMapper;
using FoodDeliverySystem.DTOs;
using FoodDeliverySystem.ExceptionHandling;
using FoodDeliverySystem.Models;
using FoodDeliverySystem.Services.Interfaces;
using FoodDeliverySystem.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodDeliverySystem.Services
{
    public class RestaurantServiceImpl : IRestaurant
    {
        private readonly IUnitOfWork  _unitOfWork;
        private readonly IMapper _mapper;
        private readonly FoodDeliveryException _foodDeliveryException;
        public RestaurantServiceImpl(IMapper mapper, IUnitOfWork unitOfWork, FoodDeliveryException foodDeliveryException) 
        { 
            this._mapper = mapper;
            this._unitOfWork = unitOfWork;
            this._foodDeliveryException = foodDeliveryException;
                                    
        }
        public RestaurantDTO AddResturant(RestaurantDTO restaurantDTO)
        {
            if (restaurantDTO == null) 
            { 
                throw new FoodDeliveryException("Restaurent object is Null", 403);
            }
            else
            {
                var Restaurant = _mapper.Map<Restaurant>(restaurantDTO);
                _unitOfWork.RestaurantRepository.Add(Restaurant);
                _unitOfWork.Commit();
                var RestaurantDTO = _mapper.Map<RestaurantDTO>(Restaurant);
                return RestaurantDTO;
            }
        }

        public void DeleteResturant(int Id)
        {
            var FindRestaurant = _unitOfWork.RestaurantRepository.GetById(Id);
            if (FindRestaurant != null)
            {
                _unitOfWork.RestaurantRepository.Delete(FindRestaurant);
            }
            else
            {
                throw new FoodDeliveryException("Restaurent Data not Found", 404);
            }
        }

        public IEnumerable<RestaurantDTO> GetAllRestuarant()
        {
            var restaurants = _unitOfWork.RestaurantRepository.GetAll();
            if (restaurants.Any())
            {
                var RestaurentDToList= _mapper.Map<IEnumerable<RestaurantDTO>>(restaurants);
                return RestaurentDToList;
            }
            else
            {
                throw new FoodDeliveryException("List is Empty or Records Not Found", 404);
            }
        }

        public RestaurantDTO GetResturant(int Id)
        {
            var FindRestaurant = _unitOfWork.RestaurantRepository.GetById(Id);
            if (FindRestaurant == null)
            {
                throw new FoodDeliveryException("Restaurent Data not Found", 404);
               
            }
            else
            {
                return _mapper.Map<RestaurantDTO>(FindRestaurant);
            }
        }

        public RestaurantDTO UpdateResturant(int Id, RestaurantDTO restaurantDTO)
        {
            var FindRestaurent = _unitOfWork.RestaurantRepository.GetById(Id);
            if (restaurantDTO == null && FindRestaurent == null)
            {
                throw new FoodDeliveryException("Restaurent object is Null", 403);
            }
            else
            {
                var Restaurant = _mapper.Map<Restaurant>(restaurantDTO);
                Restaurant.Name = restaurantDTO.Name;
                Restaurant.Location = restaurantDTO.Location;
                _unitOfWork.RestaurantRepository.Update(Restaurant);
                _unitOfWork.Commit();
                var RestaurantDTO = _mapper.Map<RestaurantDTO>(Restaurant);
                return RestaurantDTO;
            }
        }
    }
}
