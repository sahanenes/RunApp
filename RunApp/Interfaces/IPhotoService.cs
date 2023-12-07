using CloudinaryDotNet.Actions;

namespace RunApp.Interfaces
{
    public interface IPhotoService
    { 
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
 
    }
}
