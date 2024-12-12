using MediatR;
using RestaurantSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Commands
{
    public class AddFeedbackResponseCommand : IRequest<bool>
    {
        public int FeedbackId { get; set; }
        public string ResponseMessage { get; set; }
        public string RespondedById { get; set; }
        public DateTime? SubmitedDate { get; set; }
        public AddFeedbackResponseCommand()
        {
            this.SubmitedDate = DateTime.Now;
        }
    }
}
