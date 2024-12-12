using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Application.DTOs;
using RestaurantSystem.Application.IRepositories.Query;
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
    public class FeedbackQueryRepository :  IFeedbackQueryRepository
    {
        protected readonly RestaurantDbContext _context;
        public FeedbackQueryRepository(RestaurantDbContext context) 
        {
            _context = context;
        }
        public async Task<List<Feedback>> GetByRestorantId(int restorantId)
        {
                var result = await _context.Feedbacks
                .Include(f => f.Responses)  
                .Where(f => f.RestaurantId == restorantId)
                .ToListAsync();
            return result;
        }
    }
}
