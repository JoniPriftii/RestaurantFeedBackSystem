using RestaurantSystem.Application.IRepositories.Query;
using RestaurantSystem.Application.IRepositories.Query.Base;
using RestaurantSystem.Core.Entities;
using RestaurantSystem.Infrastructure.Data;
using RestaurantSystem.Infrastructure.Repositories.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Infrastructure.Repositories.Query
{
    public class RestaurantQueryRepository : QueryRepository<Restaurant>, IRestaurantQueryRepository
    {

        public RestaurantQueryRepository(RestaurantDbContext context) : base(context)
        {

        }
    }
}
