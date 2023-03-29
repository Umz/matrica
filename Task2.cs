using System;
//using System.Data.DataTable;

namespace ArithmeticCalculator
{
    class Task2
    {

        static void DoArithmetic(int n1, int n2, string symbol)
        {
            if (symbol.Contains("+"))
            {
            	Console.WriteLine(n1 + n2);
            }
            else if (symbol.Contains("-"))
            {
            	Console.WriteLine(n1 - n2);
            }
            else if (symbol.Contains("*"))
            {
            	Console.WriteLine(n1 * n2);
            }
            else if (symbol.Contains("/"))
            {
            	Console.WriteLine(n1 / n2);
            }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
				string[] parts = input.Split(new char[] { '+', '-', '*', '/' }, StringSplitOptions.None);
                int num1 = int.Parse(parts[0]);
                int num2 = int.Parse(parts[1]);
                
                DoArithmetic(num1, num2, input);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please input integers only with only one +, -, * or / operator");
            }
        }
    }
}
