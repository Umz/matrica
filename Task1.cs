using System;

namespace TrianglePrinter
{
    class Task1
    {

        static void PrintTriangle(int max)
        {
            int rows = max * 2;
            for (int i = 0; i<rows; i++)
            {
                int amt = i > max ? max - (i - max) : i;
                string stars = new string ('*', amt);
                Console.WriteLine(stars);
            }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                int size = int.Parse(input);
                PrintTriangle(size);
            }
            catch (Exception e)
            {
                Console.WriteLine("Please input integers only.");
            }
        }
    }
}
