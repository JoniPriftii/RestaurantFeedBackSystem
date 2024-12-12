using RestaurantSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.DTOs
{
    public class FeedbackDto
    {
        public int RestaurantId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime SubmitedDate { get; set; }
        public ICollection<FeedbackResponseDto> Responses { get; set; }
    }
}
