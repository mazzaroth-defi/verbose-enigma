using AutoMapper;
using EmotionTracker.Application.Requests.Identity;
using EmotionTracker.Application.Responses.Identity;

namespace EmotionTracker.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimsResponse, RoleClaimsRequest>().ReverseMap();
        }
    }
}