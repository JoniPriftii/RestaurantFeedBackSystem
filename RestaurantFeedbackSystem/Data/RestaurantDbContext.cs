using Microsoft.EntityFrameworkCore;
using RestaurantFeedbackSystem.Domain.Entities;

namespace RestaurantFeedbackSystem.Data
{
    public class RestaurantDbContext: DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options) { }

        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FeedbackResponse> FeedbackResponses { get; set; }
    }
}
