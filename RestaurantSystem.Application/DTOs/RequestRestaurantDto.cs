using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantSystem.Application.DTOs
{
    public class RequestRestaurantDto
    {
        public string RestaurantName { get; set; }
        public string Location { get; set; }
    }
}
