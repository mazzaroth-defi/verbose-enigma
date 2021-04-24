using EmotionTracker.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionTracker.Domain.Entities.Emotions
{
    /// <summary>
    /// An emotion as defined by Websters.
    /// </summary>
    public class Emotion : AuditableEntity
    {
        /// <summary>
        /// Name of the emotion.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Can be used for fun emojis.
        /// </summary>
        [Column(TypeName = "text")]
        public string ImageDataURL { get; set; }

        /// <summary>
        /// Description of the emotion.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// What does it feel like.
        /// </summary>
        public string Definition { get; set; }

        /// <summary>
        /// ID of the parent emotion.
        /// </summary>
        public int ParentEmotionId { get; set; }

        /// <summary>
        /// Emotions can have parents, and thereby children.
        ///
        /// Ex: Loving <- Peaceful <- Happy. Where happy is the root parent.
        /// </summary>
        public virtual Emotion ParentEmotion { get; set; }
    }
}