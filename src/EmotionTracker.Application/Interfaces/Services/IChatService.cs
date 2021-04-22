using EmotionTracker.Application.Models.Chat;
using EmotionTracker.Application.Responses.Identity;
using EmotionTracker.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmotionTracker.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}