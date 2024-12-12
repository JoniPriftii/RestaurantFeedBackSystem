using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Application.IRepositories.Command;
using RestaurantSystem.Core.Entities;
using RestaurantSystem.Infrastructure.Data;
using RestaurantSystem.Infrastructure.Repositories.Command.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Infrastructure.Repositories.Command
{
    public class RestaurantCommandRepository : CommandRepository<Restaurant>, IRestaurantCommandRepository
    {
        private readonly RestaurantDbContext _context;
        public RestaurantCommandRepository(RestaurantDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Restaurant> UpdateRestaurantRanking(int restaurantId)
        {
            var restaurant = await _context.Restaurants.FindAsync(restaurantId);
            if (restaurant == null)
            {
                throw new KeyNotFoundException("Restaurant not found");
            }

            var feedbacks = await _context.Feedbacks
                .Where(f => f.RestaurantId == restaurantId)
                .ToListAsync();

            double averageRating = feedbacks.Any()
                ? feedbacks.Average(f => f.Rating)
                : 0;

            restaurant.Rating = averageRating;

            await _context.SaveChangesAsync();

            return restaurant;
        }
    }
}
