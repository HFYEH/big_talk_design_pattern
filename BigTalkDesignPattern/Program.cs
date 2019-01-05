using System;

namespace SimpleFactory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter number A:");

                string strNumberA = Console.ReadLine();

                Console.WriteLine("Please enter number operator (+,-,*,/)");

                string strOperator = Console.ReadLine();

                Console.WriteLine("Please enter number B:");

                string strNumberB = Console.ReadLine();

                string Result;

                switch (strOperator)
                {
                    case "+":
                        Result = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
                        break;
                    case "-":
                        Result = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
                        break;
                    case "*":
                        Result = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
                        break;
                    case "/":
                        if (Math.Abs(Convert.ToDouble(strNumberB) - 0.0) < 0.0001)
                        {
                            throw new Exception("Cannot be zero!");
                        }
                        else
                        {
                            Result = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
                        }
                        break;
                    default:
                        Result = "None";
                        break;
                }

                Console.WriteLine("The result is: " + Result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error: " + ex.Message);
            }
        }
    }
}
