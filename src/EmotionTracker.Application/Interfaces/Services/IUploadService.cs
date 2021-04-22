using EmotionTracker.Application.Requests;

namespace EmotionTracker.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}