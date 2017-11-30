using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DomainModel;

namespace MovingAverageCalc
{
    public class MovingAverageCalculate
    {
        public List<DateTime> date;
        public List<double> rate;
        public List<double> sma;
        public List<double> ema;
        private List<CurrencyRate> currencyList;
        private int count;
        private double parametrEMA;
        private TypeRate typeRate;


        public MovingAverageCalculate()
        {
            date = new List<DateTime>();
            rate = new List<double>();
            sma = new List<double>();
            ema = new List<double>();
        }

        public void Calculate(List<CurrencyRate> _currencyList, int _count, double _parametrEMA, TypeRate _typeRate)
        {
            currencyList = _currencyList;
            count = _count;
            parametrEMA = _parametrEMA;
            typeRate = _typeRate;

            for (int i = 0; i < count; i++)
            {
                date.Add(currencyList[i].Date);
            }

            List<double> currencyRate = new List<double>();
            double sum = 0;

            switch (typeRate.Name)
            {
                case "Close":
                    currencyRate.AddRange(currencyList.Select(item => item.Close));

                    for (int i = 0; i < count; i++)
                    {
                        sum += currencyRate[i];
                        sma.Add(sum / (i + 1));
                    }
                    ema.Add(sma[0]);
                    for (int i = 1; i < count; i++)
                    {
                        //                        EMA = (CLOSE(i) * P) + (EMA(i - 1) * (1 - P))
                        //                        где:
                        //                        CLOSE(i) — цена закрытия текущего периода;
                        //                        EMA(i - 1) — значение скользящего среднего предыдущего периода;
                        //                        P — доля использования значения цен.
                        ema.Add(currencyRate[i] * parametrEMA + (ema[i - 1] * (1 - parametrEMA)));
                    }
                    break;
                case "Open":
                    currencyRate.AddRange(currencyList.Select(item => item.Open));
                    //double sum = 0;
                    for (int i = 0; i < count; i++)
                    {
                        sum += currencyRate[i];
                        sma.Add(sum / (i + 1));
                    }
                    ema.Add(sma[0]);
                    for (int i = 1; i < count; i++)
                    {
                        ema.Add(currencyRate[i] * parametrEMA + (ema[i - 1] * (1 - parametrEMA)));
                    }
                    break;
                case "High":
                    currencyRate.AddRange(currencyList.Select(item => item.High));
                    for (int i = 0; i < count; i++)
                    {
                        sum += currencyRate[i];
                        sma.Add(sum / (i + 1));
                    }
                    ema.Add(sma[0]);
                    for (int i = 1; i < count; i++)
                    {
                        ema.Add(currencyRate[i] * parametrEMA + (ema[i - 1] * (1 - parametrEMA)));
                    }
                    break;
                default:
                    currencyRate.AddRange(currencyList.Select(item => item.Low));
                    for (int i = 0; i < count; i++)
                    {
                        sum += currencyRate[i];
                        sma.Add(sum / (i + 1));
                    }
                    ema.Add(sma[0]);
                    for (int i = 1; i < count; i++)
                    {
                        ema.Add(currencyRate[i] * parametrEMA + (ema[i - 1] * (1 - parametrEMA)));
                    }
                    break;
            }
            
            for (int i = 0; i < count; i++)
            {
                rate.Add(currencyRate[i]);
            }

        }

        public void Dispose()
        {
            date = null;
            rate = null;
            sma = null;
            ema = null;
            currencyList = null;
            count = 0;
            parametrEMA = 0;
            typeRate = null;
        }

    }
}
