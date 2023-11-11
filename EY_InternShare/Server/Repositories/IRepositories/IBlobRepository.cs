using EY_InternShare.Shared;

namespace EY_InternShare.Server.Repositories.IRepositories
{
    public interface IBlobRepository
    {
        Task<BlobObject> GetBlobFile(string url);
        Task<string> UploadBlobFile(string filePath, string filename);
        void DeleteBlob(string path);
        Task<List<string>> ListBlobs();
    }
}
