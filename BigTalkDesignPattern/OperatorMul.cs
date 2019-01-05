using System;

namespace SimpleFactory
{
    public class OperatorMul : Operator
    {
        public override double GetResult(double numberA, double numberB)
        {
            double result = 0;
            result = numberA * numberB;
            return result;
        }
    }
}
