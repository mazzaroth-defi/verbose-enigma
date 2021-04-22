using EmotionTracker.Application.Features.Documents.Commands.AddEdit;
using EmotionTracker.Application.Features.Documents.Queries.GetAll;
using EmotionTracker.Application.Requests.Documents;
using EmotionTracker.Shared.Wrapper;
using System.Threading.Tasks;

namespace EmotionTracker.Client.Infrastructure.Managers.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}