using RestaurantSystem.Application.IRepositories.Command.Base;
using RestaurantSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.IRepositories.Command
{
    public interface IRestaurantCommandRepository : ICommandRepository<Restaurant>
    {
        public Task<Restaurant> UpdateRestaurantRanking(int restaurantId);
    }
}
