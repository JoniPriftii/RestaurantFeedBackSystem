﻿using RestaurantSystem.Application.DTOs;
using RestaurantSystem.Application.IRepositories.Query.Base;
using RestaurantSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.IRepositories.Query
{
    public interface IFeedbackQueryRepository 
    {
        Task<List<Feedback>> GetByRestorantId(int restorantId);

    }
}
