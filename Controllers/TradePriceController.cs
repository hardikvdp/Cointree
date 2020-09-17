using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cointree.Models;
using Cointree.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cointree.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TradePriceController : ControllerBase
    {
        private readonly ICointreeService _cointreeService;

        public TradePriceController(ICointreeService cointreeService)
        {
            _cointreeService = cointreeService;
        }

        //[HttpGet]
        //public async Task<IEnumerable<ResponseData>> GetAll()
        //{
        //    return await _cointreeService.GetDataAsync();
        //}
                
        [HttpGet("{coinSymbol=BTC}")]
        public async Task<ResponseData> GetDataViaToken(string coinSymbol)
        {
            return await _cointreeService.GetDataViaTokenAsync(coinSymbol);
        }
    }
}
