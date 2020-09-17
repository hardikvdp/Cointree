using Cointree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cointree.Services
{
    public interface ICointreeService
    {
        Task<List<ResponseData>> GetDataAsync();
        Task<ResponseData> GetDataViaTokenAsync(string coinSymbol);
    }
}
