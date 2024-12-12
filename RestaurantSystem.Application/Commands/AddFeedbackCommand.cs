using MediatR;
using RestaurantSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Commands
{
    public class AddFeedbackCommand : IRequest<bool>
    {
        public int RestaurantId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime? SubmitedDate { get; set; }
        public AddFeedbackCommand()
        {
            this.SubmitedDate = DateTime.Now;
        }
    }
}
