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
                    if (Math.Abs( Convert.ToDouble(B) - 0.0 ) < 0.0001)
                    {
                        throw new Exception("Cannot be zero!");
                    }
                    else
                    {
                        Result = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(B));
                    }
                }
                else
                {
                    Result = "None";
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
