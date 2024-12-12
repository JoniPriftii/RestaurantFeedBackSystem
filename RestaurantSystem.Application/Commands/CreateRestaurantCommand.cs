using MediatR;
using RestaurantSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Commands
{
    public class CreateRestaurantCommand : IRequest<bool>
    {
        public string RestaurantName { get; set; }
        public string Location { get; set; }
        public double? Rating { get; set; }

        public CreateRestaurantCommand()
        {
            this.Rating = 0;
        }
    }
}
