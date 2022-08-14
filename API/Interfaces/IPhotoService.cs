using System.Threading.Tasks;
using CloudinaryDotNet.Actions;

namespace API.Interfaces
{
    public interface IPhotoService
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeleteFolderResult> DeletePhotoAsync(string publicId);
    }
}
