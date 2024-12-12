using MediatR;
using RestaurantSystem.Application.DTOs;
using RestaurantSystem.Application.IRepositories.Query;
using RestaurantSystem.Application.Mapper;
using RestaurantSystem.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Handlers.QueryHandlers
{
    public class GetFeedbackHandler : IRequestHandler<GetFeedbackQuery, List<FeedbackDto>>
    {
        private readonly IFeedbackQueryRepository _feedbackQueryRepository;
        public GetFeedbackHandler(IFeedbackQueryRepository feedbackQueryRepository)
        {
            _feedbackQueryRepository = feedbackQueryRepository;
        }
        public async Task<List<FeedbackDto>> Handle(GetFeedbackQuery request, CancellationToken cancellationToken)
        {
            var result = await _feedbackQueryRepository.GetByRestorantId(request.RestorantId);
        
            return CustomMapper.Mapper.Map<List<FeedbackDto>>(result);
        }
    }
}
