using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Application.Commands;
using RestaurantSystem.Application.DTOs;
using RestaurantSystem.Application.Queries;

namespace RestaurantSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : Controller
    {
        private readonly IMediator _mediator;
        public RestaurantController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{restaurantId}")]
        public async Task<ActionResult<RestaurantDto>> GetRestaurantDetails(int restaurantId)
        {
            var result = await _mediator.Send(new GetRestaurantQuery(restaurantId));
            if (result == null)
                return NotFound("Restaurant not found");

            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<ActionResult<RestaurantDto>> GetRestaurantDetails([FromBody] CreateRestaurantCommand restaurant)
        {
            var result = await _mediator.Send(restaurant);
            if (result == null)
                return BadRequest("Failed to create restaurant.");

            return Ok(result);
        }
    }
}
