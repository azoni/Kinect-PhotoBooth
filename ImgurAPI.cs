using Imgur.API;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System;

namespace azoni
{
    class ImgurAPI
    {

        public static async Task UploadImage(string imageLocation)
        {

            try
            {
                var client = new ImgurClient("c8b369dbdf42c17", "4d26cb345e5f771a832debbe317f4ad9a40cecbb");
                var endpoint = new ImageEndpoint(client);
                Debug.WriteLine(imageLocation);
                IImage image2;// = await endpoint.UploadImageUrlAsync(imageLocation);
                //IImage image;

                using (var fs = new FileStream(imageLocation, FileMode.Open))
                {
                    image2 = await endpoint.UploadImageStreamAsync(fs);
                }
                //using (var fs = new FileStream(@imageLocation, FileMode.Open))
                //{
                //    image = await endpoint.UploadImageStreamAsync(fs);

                //}
                Debug.Write("Image uploaded. Image Url: " + image2.Link);
            }
            catch (ImgurException imgurEx)
            {
                Debug.Write("An error occurred uploading an image to Imgur.");
                Debug.Write(imgurEx.Message);
            }
        }

    }
}
