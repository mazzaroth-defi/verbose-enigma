using EmotionTracker.Application.Interfaces.Common;
using EmotionTracker.Application.Requests.Identity;
using EmotionTracker.Shared.Wrapper;
using System.Threading.Tasks;

namespace EmotionTracker.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}