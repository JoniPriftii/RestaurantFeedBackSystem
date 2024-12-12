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
    public class FeedbackCommandRepository : CommandRepository<Feedback>, IFeedbackCommandRepository
    {
        public FeedbackCommandRepository(RestaurantDbContext context) : base(context)
        {

        }
    }
}
