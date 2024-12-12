using MediatR;
using RestaurantSystem.Application.Commands;
using RestaurantSystem.Application.DTOs;
using RestaurantSystem.Application.IRepositories.Command;
using RestaurantSystem.Application.Mapper;
using RestaurantSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Handlers.CommandHandlers
{
    public class AddRestaurantHandler : IRequestHandler<CreateRestaurantCommand, bool>
    {
        private readonly IRestaurantCommandRepository _restaurantRepository;

        public AddRestaurantHandler(IRestaurantCommandRepository repository)
        {
            _restaurantRepository = repository;
        }
        public async Task<bool> Handle(CreateRestaurantCommand request, CancellationToken cancellationToken)
        {
            var restaurantEntity= CustomMapper.Mapper.Map<Restaurant>(request);
            if (restaurantEntity == null)
                throw new ApplicationException("There is a problem in mapper");

            try
            {
                var newRestaurant = await _restaurantRepository.AddAsync(restaurantEntity);
                return true;
            }
            catch (Exception ex) 
            {
                throw new Exception("Something went wrong on AddRestaurantHandler");
            }

        }
    }
}
