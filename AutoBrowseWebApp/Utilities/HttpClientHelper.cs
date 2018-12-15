using System;
using System.Collections.Generic;
using System.Net.Http;

namespace AutoBrowseWebApp.Utilities
{
    public static class HttpClientHelper
    {
        private static HttpClient Client { get; }

        static HttpClientHelper()
        {
            Client = new HttpClient { BaseAddress = new Uri("https://github.com/") };
        }

        public static HttpResponseMessage Get()
        {
            return Client.GetAsync("").Result;
        }

        public static HttpResponseMessage Post()
        {
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("", "")
            });
            return Client.PostAsync("", content).Result;
        }
    }
}
