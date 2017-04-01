using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace FaceBooth
{
    
    class TwitterAPI
    {
        
        static void TweetPicture(string path)
        {
            var credentials = new TwitterCredentials("ZPelDIgzmbLcpxB4qqOwrG52U",
                                                     "0mRtHj3gF1sakk3V22gafM4EVttn3v5QrGbwkkdyjyA0hYxAOe",
                                                     "848276891693862912-kvPEuoUKboZzp9H4tcqgtYEnE5wAgUv",
                                                     "uy2Xgq2aBBtMDt5yE6NKQa7BwDJrvabckbJuUiZCBwvbR");
            Auth.SetCredentials(credentials);

            byte[] file1 = File.ReadAllBytes(path);
            var media = Upload.UploadImage(file1);

            var tweet = Tweet.PublishTweet("LA HACKS 2017!", new PublishTweetOptionalParameters
            {
                Medias = new List<IMedia> { media }
            });

        }
    }
}
