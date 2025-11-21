using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Text;

namespace CalculatorNew
{
    public class Maths
    {
        Input input = new Input();
        public int Addition()
        {
            List<int> Numbers = new List<int>();
            while (true)
            {
                int add = input.ReadInt("Enter numbers to Add (Enter \"0\" to add all) ");
                if (add == 0) break;
                Numbers.Add(add);
            }

            int sum = 0;
            foreach (var number in Numbers)
                sum += number;

            return sum;
        }
        public int Subtraction()
        {
            List<int> Numbers = new List<int>();
            while (true)
            {
                int sub = input.ReadInt("Enter numbers to Subtract (Enter \"0\" to subtract the numbers from the first number) ");
                if (sub == 0) break;
                Numbers.Add(sub);
                
            }
            int sum = Numbers[0];
            for (int i = 1; i < Numbers.Count; i++)
            {
                sum-=Numbers[i];   
            }
            return sum;
        }
        public int Multiplication()
        {
            List<int> Numbers = new List<int>();
            while (true)
            {
                int multiply = input.ReadInt("Enter numbers to multiply (Enter \"0\" to multiply all) ");
                if (multiply == 0) break;
                Numbers.Add(multiply);
            }
            int sum = 1;
            foreach (var item in Numbers)
            {
                sum*=item;
            }
            return sum;
        }
        public void Division()
        {
            double dividend = input.ReadDouble("Enter a number to divide (Dividend)");
            double divisor = input.ReadDouble("Enter a number to divide it by (Divisor)");
            Console.WriteLine($"{dividend} Divided by {divisor} is {dividend / divisor} and the Remainder is {dividend % divisor}");
        }
        public double Root()
        {
            double root = input.ReadInt("Enter a number whose root you want to find");
            double ans = Math.Sqrt(root);
            return ans;
        }
        public int SquareAndCube()
        {
            while (true)
            {
                int UserChoice = input.ReadInt("Enter \"2\" to find Square or \"3\" to find cube");
                if (UserChoice == 2)
                {
                    int square = input.ReadInt("Enter the number whose square you want to find");
                    return square * square;
                }
                else if (UserChoice == 3)
                {
                    int cube = input.ReadInt("Enter the number whose cube you want to find");
                    return cube * cube;
                }
                else
                {
                    Console.WriteLine("Enter \"2\" to find Square or \"3\" to find cube");
                }
            }
        }
        public int Secret()
        {
            int loopNumber = input.ReadInt("Enter a number that u wanna add power to");
            int loopTime = input.ReadInt("Enter the power (exponent)");
            int result = 1;
            for (int i = 0; i < loopTime; i++)
            {
                result = result * loopNumber;
            }
            return result;
        }
    }
}
