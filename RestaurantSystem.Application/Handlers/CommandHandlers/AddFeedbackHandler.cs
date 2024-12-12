using MediatR;
using RestaurantSystem.Application.Commands;
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
    public class AddFeedbackHandler : IRequestHandler<AddFeedbackCommand, bool>
    {
        private readonly IRestaurantCommandRepository _restaurantCommandRepository;
        private readonly IFeedbackCommandRepository _feedbackRepository;

        public AddFeedbackHandler(
            IFeedbackCommandRepository feedbackRepository,
            IRestaurantCommandRepository restaurantCommandRepository)
        {
            _feedbackRepository = feedbackRepository;
            _restaurantCommandRepository = restaurantCommandRepository;
        }
        public async Task<bool> Handle(AddFeedbackCommand request, CancellationToken cancellationToken)
        {
            var feedbackEntity = CustomMapper.Mapper.Map<Feedback>(request);
            if (feedbackEntity == null)
            {
                Console.WriteLine($"Problems with mapper");
                return false;
            }
            try{
                await _restaurantCommandRepository.ExecuteInTransactionAsync(async () =>
                {
                    var newFeedback = await _feedbackRepository.AddAsync(feedbackEntity);

                    await _restaurantCommandRepository.UpdateRestaurantRanking(request.RestaurantId);

                });
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Transaction failed: {ex.Message}");
                return false;
            }
        }
    }
}
