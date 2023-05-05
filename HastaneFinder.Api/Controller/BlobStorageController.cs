

using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;


namespace HastaneFinder.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlobStorageController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            // Blob Storage hesap bilgileri
            var accountName = "blobstoragehospitalieasy";
            var accountKey = "M+s4eOW4yK5dRihaEqAkcX2C4wnJjGypkhWpenvPD+iCHtwskE2/O6oIkef2R3i5THhdkVsMmEYq+AStkzIQcA==";
            var connectionString = $"DefaultEndpointsProtocol=https;AccountName={accountName};AccountKey={accountKey};EndpointSuffix=core.windows.net";

            // Blob Container adı
            var containerName = "fileupload";

            // Blob Container referansı
            var container = new BlobContainerClient(connectionString, containerName);

            // Blob referansı
            if (file == null)
            {
                return BadRequest("Dosya seçilmedi.");
            }

            var blob = container.GetBlobClient(file.FileName);


            // Dosya akışını al
            using var stream = file.OpenReadStream();

            // Blob'a dosyayı yükle
            await blob.UploadAsync(stream);

            // Başarılı yanıt döndür
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFileById(string id)
        {
            var accountName = "blobstoragehospitalieasy";
            var accountKey = "M+s4eOW4yK5dRihaEqAkcX2C4wnJjGypkhWpenvPD+iCHtwskE2/O6oIkef2R3i5THhdkVsMmEYq+AStkzIQcA==";
            var connectionString = $"DefaultEndpointsProtocol=https;AccountName={accountName};AccountKey={accountKey};EndpointSuffix=core.windows.net";

            var containerName = "fileupload";
            // Blob depolama hesabınızın ve anahtarınızın bağlantı dizesini kullanarak bir BlobServiceClient örneği oluşturun
            var blobServiceClient = new BlobServiceClient(connectionString);

            // İlgili blob konteynerine erişin
            var blobContainerClient = blobServiceClient.GetBlobContainerClient(containerName);

            // İlgili blob adı ve uzantısıyla birlikte blob nesnesine erişin
            var blobClient = blobContainerClient.GetBlobClient(id);

            // Blob'u bellekte tutmak için bir MemoryStream örneği oluşturun
            using var stream = new MemoryStream();

            // Blob'u MemoryStream'e indirin
            await blobClient.DownloadToAsync(stream);

            // MemoryStream'deki verileri byte dizisine aktarın
            var bytes = stream.ToArray();

            // Byte dizisini ve MIME türünü kullanarak bir FileContentResult nesnesi oluşturun ve geri dönün
            return new FileContentResult(bytes, "image/jpeg");
        }


    }
}
