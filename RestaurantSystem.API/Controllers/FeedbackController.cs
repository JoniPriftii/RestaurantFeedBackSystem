using MediatR;
using Microsoft.AspNetCore.Mvc;
using RestaurantSystem.Application.Commands;
using RestaurantSystem.Application.DTOs;
using RestaurantSystem.Application.Queries;

namespace RestaurantSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : Controller
    {
        private readonly IMediator _mediator;
        public FeedbackController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{restaurantId}")]
        public async Task<List<FeedbackDto>> GetRestaurantFeebacks(int restaurantId)
        {
            return await _mediator.Send(new GetFeedbackQuery(restaurantId));
        }

        [HttpPost("add")]
        public async Task<ActionResult<bool>> AddNewFeebackForRestaurant([FromBody] AddFeedbackCommand feedback)
        {
            var result = await _mediator.Send(feedback);
            if (!result)
                return BadRequest("Failed to add feedback.");

            return Ok(result);
        }

        [HttpPost("response")]
        public async Task<ActionResult<bool>> AddNewFeebackResponseFeedback([FromBody] AddFeedbackResponseCommand feedbackResponse)
        {
            var result = await _mediator.Send(feedbackResponse);
            if (!result)
                return BadRequest("Failed to add feedback response.");

            return Ok(result);
        }
    }
}
