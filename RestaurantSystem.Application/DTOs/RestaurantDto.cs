﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.DTOs
{
    public class RestaurantDto
    {
        public string RestaurantName { get; set; }
        public string Location { get; set; }
        public double Rating { get; set; }
    }
}
