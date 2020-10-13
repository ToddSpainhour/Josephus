using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Josephus
{
    public class JosephusSolver
    {
        public object Solve(int numberOfPeople, int killingInterval)
        {
            //throw new NotImplementedException();
            //return 1;

            if (killingInterval == 1) return numberOfPeople;
            //if (killingInterval == 2) return numberOfPeople / 2;
            //return 0;
            if (killingInterval == 2)
            {
                Enumerable.Range(1, numberOfPeople).Where(number => number % 2 > 0).Max();
            }
            return numberOfPeople;
        }
    }
}
