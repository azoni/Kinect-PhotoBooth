using Imgur.API;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            test = await ImgurAPI.UploadImage("visual.png");
            
        }
    }
    public class ImgurAPI
    {

        public static async Task UploadImage(string imageLocation)
        {
            
            try
            {
                var client = new ImgurClient("c439efea9ce88d4", "64a28e3aa42e95c066f10a8b97295e69b828b294");
                var endpoint = new ImageEndpoint(client);
                IImage image;

                using (var fs = new FileStream(imageLocation, FileMode.Open))
                {
                    
                    image = await endpoint.UploadImageStreamAsync(fs);

                }
                Debug.Write("Image uploaded. Image Url: ");
            }
            catch (ImgurException imgurEx)
            {
                Debug.Write("An error occurred uploading an image to Imgur.");
                Debug.Write(imgurEx.Message);
            }
            return new Task(null);
        }
    }
}
