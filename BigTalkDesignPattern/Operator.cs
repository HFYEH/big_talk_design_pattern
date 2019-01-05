using System;

namespace SimpleFactory
{
    public class Operator
    {
        public static double GetResult(double numberA, double numberB, string operate)
        {
            double result = 0d;

            switch (operate)
            {
                case "+":
                    result = numberA + numberB;
                    break;
                case "-":
                    result = numberA - numberB;
                    break;
                case "*":
                    result = numberA * numberB;
                    break;
                case "/":
                    result = numberA / numberB;

                    break;
            }

            return result;
        }
    }
}
