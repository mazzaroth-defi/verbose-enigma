using EmotionTracker.Application.Interfaces.Services;
using System;

namespace EmotionTracker.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}