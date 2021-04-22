using EmotionTracker.Application.Responses.Audit;
using EmotionTracker.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmotionTracker.Client.Infrastructure.Managers.Audit
{
    public interface IAuditManager : IManager
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync();

        Task<string> DownloadFileAsync();
    }
}