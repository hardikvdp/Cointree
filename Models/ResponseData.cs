using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cointree.Models
{
    public class ResponseData
    {
        public string Sell { get; set; }
        public string Buy { get; set; }
        public decimal Ask { get; set; }
        public decimal Bid { get; set; }
        public decimal Rate { get; set; }
        public decimal SpotRate { get; set; }
        public string Market { get; set; }
        public DateTime TimeStamp { get; set; }
        public string RateType { get; set; }
        public string RateSteps { get; set; }
    }
}
