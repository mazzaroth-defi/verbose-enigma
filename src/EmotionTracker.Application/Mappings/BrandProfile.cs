using AutoMapper;
using EmotionTracker.Application.Features.Brands.AddEdit;
using EmotionTracker.Application.Features.Brands.Queries.GetAll;
using EmotionTracker.Application.Features.Brands.Queries.GetById;
using EmotionTracker.Domain.Entities.Catalog;

namespace EmotionTracker.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}