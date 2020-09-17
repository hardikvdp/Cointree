using Cointree.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Cointree.Services
{
    public class CointreeService : ICointreeService
    {
        private WebClient _client;
        private IConfiguration _config;

        private string _serviceUrl { get; set; }

        public CointreeService(IConfiguration config)
        {
            _client = new WebClient();
            _config = config;

            this._serviceUrl = _config["BaseServiceURL"];
        }
        public async Task<List<ResponseData>> GetDataAsync()
        {
            var res = await _client.DownloadStringTaskAsync(_serviceUrl);
            var data = JsonConvert.DeserializeObject<List<ResponseData>>(res);
            return data;
        }


        public async Task<ResponseData> GetDataViaTokenAsync(string coinSymbol)
        {
            string url = $"{_serviceUrl}/{coinSymbol}";
            var res = await _client.DownloadStringTaskAsync(url);
            var data = JsonConvert.DeserializeObject<ResponseData>(res);
            return data;
        }
    }
}
