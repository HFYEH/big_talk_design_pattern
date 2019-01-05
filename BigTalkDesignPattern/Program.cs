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

                double result = Operator.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperator);

                string strResult = Convert.ToString(result);

                Console.WriteLine("The result is: " + strResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is an error: " + ex.Message);
            }
        }
    }
}
