namespace EmotionTracker.Application.Requests.Catalog
{
    public class UpdateProductImageRequest
    {
        public int Id { get; set; }
        public string ImageDataURL { get; set; }
    }
}