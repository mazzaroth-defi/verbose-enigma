using System.Collections.Generic;

namespace EmotionTracker.Application.Responses.Identity
{
    public class GetAllUsersReponse
    {
        public IEnumerable<UserResponse> Users { get; set; }
    }
}