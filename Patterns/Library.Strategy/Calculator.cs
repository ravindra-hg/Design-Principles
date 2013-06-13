using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.StrategyPattern
{
    public class Calculator
    {
        private ICalculate calculate = null;
        public Calculator(ICalculate calculate)
        {
            this.calculate = calculate;
        }

        public int Calculate(int i,int j)
        {
            return this.calculate.Calculate(i, j);
        }
    }
}
