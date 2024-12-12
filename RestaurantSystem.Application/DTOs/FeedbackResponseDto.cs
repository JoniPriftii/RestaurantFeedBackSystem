using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.DTOs
{
    public class FeedbackResponseDto
    {
        public string ResponseMessage { get; set; }
        public string RespondedById { get; set; }
        public DateTime SubmitedDate { get; set; }
    }
}
