using AutoMapper;
using RestaurantSystem.Application.Commands;
using RestaurantSystem.Application.DTOs;
using RestaurantSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Restaurant, RestaurantDto>().ReverseMap();
            CreateMap<Restaurant, CreateRestaurantCommand>().ReverseMap();
            CreateMap<Restaurant, RequestRestaurantDto>().ReverseMap();
            CreateMap<Feedback, FeedbackDto>().ReverseMap();
            CreateMap<Feedback, FeedbackResponseDto>().ReverseMap();
            CreateMap<Feedback, AddFeedbackCommand>().ReverseMap();
            CreateMap<FeedbackResponse, AddFeedbackResponseCommand>().ReverseMap();
            CreateMap<FeedbackResponse, FeedbackResponseDto>().ReverseMap();
        }
    }
}
