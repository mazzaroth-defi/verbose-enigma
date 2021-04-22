using EmotionTracker.Application.Features.Brands.AddEdit;
using EmotionTracker.Application.Features.Brands.Queries.GetAll;
using EmotionTracker.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmotionTracker.Client.Infrastructure.Managers.Catalog.Brand
{
    public interface IBrandManager : IManager
    {
        Task<IResult<List<GetAllBrandsResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditBrandCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}