using MediatR;
using RestaurantSystem.Application.DTOs;
using RestaurantSystem.Application.IRepositories.Query;
using RestaurantSystem.Application.Mapper;
using RestaurantSystem.Application.Queries;
using RestaurantSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Handlers.QueryHandlers
{
    public class GetRestaurantHandler : IRequestHandler<GetRestaurantQuery, RestaurantDto>
    {
        private readonly IRestaurantQueryRepository _restaurantRepository;
        public GetRestaurantHandler(IRestaurantQueryRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }
        public async Task<RestaurantDto> Handle(GetRestaurantQuery request, CancellationToken cancellationToken)
        {
            var result = await _restaurantRepository.GetByIdAsync(request.Id);

            return CustomMapper.Mapper.Map<RestaurantDto>(result);
        }
    }
}
