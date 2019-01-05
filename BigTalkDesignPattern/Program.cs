using System;

namespace BigTalkDesignPattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter number A:");

            string A = Console.ReadLine();

            Console.WriteLine("Please enter number operator (+,-,*,/)");

            string Operator = Console.ReadLine();

            Console.WriteLine("Please enter number B:");

            string B = Console.ReadLine();

            string Result;

            if (Operator == "+")
            {
                Result = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(B));
            }
            else if (Operator == "-")
            {
                Result = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(B));
            }
            else if (Operator == "*")
            {
                Result = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(B));
            }
            else if (Operator == "/")
            {
                Result = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(B));
            }
            else
            {
                Result = "None";
            }

            Console.WriteLine("The result is: " + Result);
        }
    }
}
