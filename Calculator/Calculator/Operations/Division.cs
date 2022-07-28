using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class Division : IOperation
    {
        public float Calculate(float firstValue, float secondValue)
        {
            if(secondValue == 0)
            {
                throw new DivideByZeroException();
            }

            return firstValue / secondValue;
        }
    }
}
