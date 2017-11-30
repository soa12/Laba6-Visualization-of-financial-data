using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace MovingAverageCalc
{
    public class SMACalculate : IMovingAverageCalc
    {
        public void CalcForCloseRate()
        {
            
        }

        public void CalcForHighRate()
        {
            throw new NotImplementedException();
        }

        public void CalcForLowRate()
        {
            throw new NotImplementedException();
        }

        public void CalcForOpenRate()
        {
            throw new NotImplementedException();
        }
    }
}
