using EmotionTracker.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionTracker.Domain.Entities.Emotions
{
    /// <summary>
    /// A session is every time a user records their emotions.
    /// </summary>
    public class Session : AuditableEntity
    {
        public string Title { get; set; }

        [Column(TypeName = "text")]
        public string ImageDataURL { get; set; }

        public string Description { get; set; }
        public string Definition { get; set; }

        public int ParentEmotionId { get; set; }
        public virtual Emotion ParentEmotion { get; set; }
    }
}