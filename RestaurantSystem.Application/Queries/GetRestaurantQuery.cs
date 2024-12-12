using MediatR;
using RestaurantSystem.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Queries
{
    public class GetRestaurantQuery : IRequest<RestaurantDto>
    {
        public int Id { get; set; }
        public GetRestaurantQuery(int Id)
        {
            this.Id = Id;
        }
    }
}
