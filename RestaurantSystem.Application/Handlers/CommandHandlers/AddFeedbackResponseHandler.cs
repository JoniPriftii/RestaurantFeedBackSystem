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
    public class AddFeedbackResponseHandler : IRequestHandler<AddFeedbackResponseCommand, bool>
    {
        public readonly IFeedbackResponseCommandRepository _responseRepository;
        public AddFeedbackResponseHandler(IFeedbackResponseCommandRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }
        public async Task<bool> Handle(AddFeedbackResponseCommand request, CancellationToken cancellationToken)
        {

            var responseEntity = CustomMapper.Mapper.Map<FeedbackResponse>(request);
            if (responseEntity == null)
                throw new ApplicationException("There is a problem in mapper");

            try
            {
                var newResponse = await _responseRepository.AddAsync(responseEntity);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Something went wrong on AddRestaurantHandler");
            }
        }
    }
}
