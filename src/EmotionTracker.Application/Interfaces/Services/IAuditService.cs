using EmotionTracker.Application.Responses.Audit;
using EmotionTracker.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmotionTracker.Application.Interfaces.Services
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        Task<string> ExportToExcelAsync(string userId);
    }
}