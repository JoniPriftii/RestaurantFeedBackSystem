using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantFeedbackSystem.Domain.DTOs
{
    public class RestaurantDto
    {
        public string RestaurantName { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
    }
}
