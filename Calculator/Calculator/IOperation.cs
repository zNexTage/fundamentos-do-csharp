using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IOperation
    {
        float Calculate(float firstValue, float secondValue);
    }
}
