using AutoMapper;
using EmotionTracker.Application.Responses.Identity;
using Microsoft.AspNetCore.Identity;

namespace EmotionTracker.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, IdentityRole>().ReverseMap();
        }
    }
}