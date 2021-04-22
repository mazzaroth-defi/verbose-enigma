using AutoMapper;
using EmotionTracker.Application.Features.Products.Commands.AddEdit;
using EmotionTracker.Domain.Entities.Catalog;

namespace EmotionTracker.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}