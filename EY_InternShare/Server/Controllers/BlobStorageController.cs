using EY_InternShare.Server.Repositories.IRepositories;
using EY_InternShare.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EY_InternShare.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobStorageController : ControllerBase
    {
        private readonly IBlobRepository _blobRepository;

        public BlobStorageController(IBlobRepository blobRepository)
        {
            _blobRepository = blobRepository;
        }

        [HttpGet("GetBlobFile")]
        public async Task<IActionResult> GetBlobFile(string url)
        {
            BlobObject result = await _blobRepository.GetBlobFile(url);

            return File(result.Content, result.ContentType);
        }

        [HttpPost("UploadBlobFile")]
        public async Task<IActionResult> UploadBlobFile([FromBody] BlobContentModel model)
        {
            var result = await _blobRepository.UploadBlobFile(model.FilePath, model.FileName);
            return Ok(result);
        }


        [HttpDelete("DeleteBlob")]
        public IActionResult DeleteBlob(string path)
        {
            _blobRepository.DeleteBlob(path);
            return Ok();
        }

        [HttpGet("ListBlobs")]
        public async Task<IActionResult> ListBlobs()
        {
            var result = await _blobRepository.ListBlobs();
            return Ok(result);
        }
    }
}
