using DomainModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConversion
{
    public class ConversionFromCSV : IConversion
    {
        private string path;
        private List<CurrencyRate> currencyRatesList;

        private double temp = 1.111;
        public ConversionFromCSV(string path)
        {
            this.path = path;
            currencyRatesList = new List<CurrencyRate>();
        }

        public List<CurrencyRate> ToObject()
        {
            string line;
            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] words = line.Split(',');
                        //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");                     
                        currencyRatesList.Add(new CurrencyRate()
                        {
                            Ticker = words[0],
                            Per = words[1],
                            Date = DateTime.Parse(words[2]),
                            Time = DateTime.Parse(words[3]),
                            Open = Double.Parse(words[4], new CultureInfo("en-US")),
                            High = Double.Parse(words[5], new CultureInfo("en-US")),
                            Low = Double.Parse(words[6], new CultureInfo("en-US")),
                            Close = Double.Parse(words[7], new CultureInfo("en-US")),
                            Vol = Int32.Parse(words[8])        
                        });

                        //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ru_RU");
                        //currencyRatesList[currencyRatesList.Count - 1].Date = DateTime.Parse(words[2]);
                        //currencyRatesList[currencyRatesList.Count - 1].Time = DateTime.Parse(words[3]);
                    }
                }
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return currencyRatesList;
        }
    }
}
