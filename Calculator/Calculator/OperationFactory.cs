using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Operations;

namespace Calculator
{
    internal class OperationFactory
    {
        public IOperation Create(float operation)
        {
            switch (operation)
            {
                case (float)EOperation.SUM: return new Sum();
                case (float)EOperation.SUBTRACT: return new Subtract();
                case (float)EOperation.DIVISION: return new Division();
                case (float)EOperation.MULTIPLICATION: return new Multiplication();
                default: throw new Exception("Operação inválida");
            }

        }
    }
}
