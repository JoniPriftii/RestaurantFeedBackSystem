using MediatR;
using RestaurantSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Queries
{
    public class GetFeedbackQuery : IRequest<List<FeedbackDto>>
    {
        public int RestorantId {  get; set; }
        public GetFeedbackQuery(int Id)
        {
            this.RestorantId = Id;
        }
    }
}
