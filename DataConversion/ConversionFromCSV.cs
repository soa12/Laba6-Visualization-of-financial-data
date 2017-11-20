using DomainModel;
using System;
using System.Collections.Generic;
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
                        currencyRatesList.Add(new CurrencyRate()
                        {
                            Ticker = words[0],
                            Per = words[1],
                            Date = DateTime.Parse(words[2]),
                            Time = DateTime.Parse(words[3]),
                            Open = Double.Parse(words[4]),
                            High = Double.Parse(words[5]),
                            Low = Double.Parse(words[5]),
                            Close = Double.Parse(words[5]),
                            Vol = Int32.Parse(words[6])                          
                        });
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
