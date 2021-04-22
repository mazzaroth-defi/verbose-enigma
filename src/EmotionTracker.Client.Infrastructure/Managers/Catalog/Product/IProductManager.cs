using EmotionTracker.Application.Features.Products.Commands.AddEdit;
using EmotionTracker.Application.Features.Products.Queries.GetAllPaged;
using EmotionTracker.Application.Requests.Catalog;
using EmotionTracker.Shared.Wrapper;
using System.Threading.Tasks;

namespace EmotionTracker.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<string> ExportToExcelAsync();
    }
}