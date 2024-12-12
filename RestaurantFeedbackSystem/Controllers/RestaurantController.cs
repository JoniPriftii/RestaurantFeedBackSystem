using Microsoft.AspNetCore.Mvc;

namespace RestaurantFeedbackSystem.Controllers
{
    public class RestaurantController : Controller
    {
        [HttpPost]
        public IActionResult AddRestaurant()
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult AddRestaurant(int restaurantId)
        {
            return Ok();
        }
    }
}
