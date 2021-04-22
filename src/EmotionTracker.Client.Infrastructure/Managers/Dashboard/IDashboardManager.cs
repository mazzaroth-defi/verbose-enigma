using EmotionTracker.Application.Features.Dashboard.GetData;
using EmotionTracker.Shared.Wrapper;
using System.Threading.Tasks;

namespace EmotionTracker.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}