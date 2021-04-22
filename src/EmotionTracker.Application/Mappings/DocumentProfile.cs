using AutoMapper;
using EmotionTracker.Application.Features.Documents.Commands.AddEdit;
using EmotionTracker.Domain.Entities;

namespace EmotionTracker.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
        }
    }
}