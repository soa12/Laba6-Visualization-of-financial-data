using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class CurrencyRate
    {
        //<TICKER>,<PER>,<DATE>,<TIME>,<OPEN>,<HIGH>,<LOW>,<CLOSE>,<VOL>
        //EURRUB,60,20171120,010000,69.4562000,69.6904000,69.4456000,69.6839000,59
        public string Ticker { get; set; }

        public string Per { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public double Open { get; set; }

        public double High { get; set; }

        public double Low { get; set; }

        public double Close { get; set; }

        public int Vol { get; set; }
    }
}
