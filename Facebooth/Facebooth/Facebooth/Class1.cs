using Imgur.API;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
namespace Facebooth
{
    class Class1
    {

        public async Task UploadImage()
        {
            try
            {
                var client = new ImgurClient("CLIENT_ID", "CLIENT_SECRET");
                var endpoint = new ImageEndpoint(client);
                var image = await endpoint.GetImageAsync("IMAGE_ID");
                Debug.Write("Image retrieved. Image Url: " + image.Link);
            }
            catch (ImgurException imgurEx)
            {
                Debug.Write("An error occurred getting an image from Imgur.");
                Debug.Write(imgurEx.Message);
            }
        }
    }
}
