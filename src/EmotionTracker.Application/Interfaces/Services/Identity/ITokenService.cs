using EmotionTracker.Application.Interfaces.Common;
using EmotionTracker.Application.Requests.Identity;
using EmotionTracker.Application.Responses.Identity;
using EmotionTracker.Shared.Wrapper;
using System.Threading.Tasks;

namespace EmotionTracker.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}