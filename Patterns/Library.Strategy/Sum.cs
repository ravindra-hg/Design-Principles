using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.StrategyPattern
{
    public class Sum:ICalculate
    {
        public int Calculate(int i, int j)
        {
            return i + j;
        }
    }
}
