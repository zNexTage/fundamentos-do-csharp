using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public class Sum : IOperation
    {
        public float Calculate(float firstValue, float secondValue)
        {
            return firstValue + secondValue;
        }
    }
}
