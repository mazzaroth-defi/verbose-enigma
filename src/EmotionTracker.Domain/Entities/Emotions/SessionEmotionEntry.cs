using EmotionTracker.Domain.Contracts;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmotionTracker.Domain.Entities.Emotions
{
    /// <summary>
    /// An emotion that was selected while recording a session.
    /// </summary>
    public class SessionEmotionEntry : AuditableEntity
    {
        public int SessionEntryId { get; set; }

        /// <summary>
        /// The <see cref="Session"/> this entry belongs too.
        /// </summary>
        public Session SessionEntry { get; set; }

        public int EmotionEntryId { get; set; }

        /// <summary>
        /// The <see cref="Emotion"/> this entry is.
        /// </summary>
        public virtual Emotion EmotionEntry { get; set; }

        /// <summary>
        /// Notes about this emotion and entry.
        /// </summary>
        public string Notes { get; set; }
    }
}