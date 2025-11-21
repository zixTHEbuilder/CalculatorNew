using CalculatorNew;
using System;
using System.Numerics;
class Program
{
    static void Main()
    {
        Input input = new Input();
        Maths maths = new Maths();
        Console.WriteLine("Calculator");
        while (true)
        { 
            int ProgramSelect = input.ReadInt("Enter the program number you want to use \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Divison \n5. Finding Root \n6. Finding Square/Cube \n7. Secret \n8. Exit Program", writeLine : true);
            switch (ProgramSelect)
            {
                case 1:
                    {
                        int sum = maths.Addition();
                        Console.WriteLine(sum); break;
                    }
                case 2:
                    {
                        int sum = maths.Subtraction();
                        Console.WriteLine(sum); break;
                    }
                case 3:
                    {
                        int sum = maths.Multiplication();
                        Console.WriteLine(sum); break;
                    }
                case 4:
                    {
                        maths.Division(); break;
                    }
                case 5:
                    {
                       double answer = maths.Root();
                       Console.WriteLine("{0:0.00}", answer); break;
                    }
                case 6:
                    {
                        int answer = maths.SquareAndCube();
                        Console.WriteLine("{0:0.00}", answer); break;
                    }
                case 7:
                    {
                        int result = maths.Secret();
                        Console.WriteLine(result); break;
                    }
                case 8:
                    {
                        Console.WriteLine("Exiting Program...");
                        return;
                    }
                default: Console.WriteLine("Error, Please Enter a valid number to choose a program"); break;
            }
        }
    }
}