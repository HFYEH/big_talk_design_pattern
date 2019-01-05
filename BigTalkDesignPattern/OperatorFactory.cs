using System;

namespace SimpleFactory
{
    public class OperatorFactory
    {
        public static Operator CreateOperator(string strOperator)
        {
            Operator op = null;
            switch (strOperator)
            {
                case "+":
                    op = new OperatorAdd();
                    break;
                case "-":
                    op = new OperatorSub();
                    break;
                case "*":
                    op = new OperatorMul();
                    break;
                case "/":
                    op = new OperatorDiv();
                    break;
            }
            return op;
        }
    }
}
