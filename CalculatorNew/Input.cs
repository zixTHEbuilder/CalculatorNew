using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace CalculatorNew
{
    public class Input
    {
        public int ReadInt(string message, bool writeLine = false)
        {
            while (true)
            {
                if (writeLine == true)
                    Console.WriteLine(message);
                else { Console.Write($"{message} : "); }
                string UserInput = Console.ReadLine();
                bool sucesss = int.TryParse(UserInput, out int value);
                if (sucesss)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid Input, Please enter a valid number");
                }
            }
        }
        public double ReadDouble(string message)
        {
            while (true)
            {
                Console.WriteLine($"{message} : ");
                string UserInput = Console.ReadLine();
                bool success = Double.TryParse(UserInput, out double value);
                if (success)
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Invalid Input, Please enter a valid number");
                }
            }
        }
    }
}
