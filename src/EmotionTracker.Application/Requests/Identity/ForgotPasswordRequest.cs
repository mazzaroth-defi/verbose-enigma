using System.ComponentModel.DataAnnotations;

namespace EmotionTracker.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}