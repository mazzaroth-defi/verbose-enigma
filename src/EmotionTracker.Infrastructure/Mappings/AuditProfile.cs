using AutoMapper;
using EmotionTracker.Application.Models.Audit;
using EmotionTracker.Application.Responses.Audit;

namespace EmotionTracker.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}