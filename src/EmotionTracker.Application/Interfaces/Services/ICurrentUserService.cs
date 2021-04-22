using EmotionTracker.Application.Interfaces.Common;

namespace EmotionTracker.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}