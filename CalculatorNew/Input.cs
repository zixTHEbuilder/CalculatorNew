using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorNew
{
    public class Input
    {
        public int ReadInt(string message)
        {
            while (true)
            {
                Console.Write($"{message} : ");
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
        public int ReadIntWriteLine(string message)
        {
            while (true)
            {
                Console.WriteLine($"{message} : ");
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
    }
}
