using System;
using System.IO;

namespace DateShifter
{
    class Task3
    {

        static void ShiftHours(string fileLine)
        {
            string[] parts = fileLine.Split(new char[] { ',' }, StringSplitOptions.None);
            string dateString = parts[0];
            double adjustment = double.Parse(parts[1]);

            DateTime dt = DateTime.Parse(dateString);
            var newDt = dt.AddHours(adjustment);

            Console.WriteLine(newDt);
        }

        static void Main(string[] args)
        {
            try
            {
                string[] lines = File.ReadAllLines("Data.txt");
                foreach (string line in lines) {
                	try
                    {
                        ShiftHours(line);
                    }
                    catch (Exception e)
                    {
                        // SKIP any lines that were not parseable
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not read the file");
            }
        }
    }
}
