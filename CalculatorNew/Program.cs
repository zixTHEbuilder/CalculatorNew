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
            int ProgramSelect = input.ReadIntWriteLine("Enter the program number you want to use \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Divison \n5. Finding Root \n6. Finding Square/Cube \n7. Secret \n8. Exit Program");
            switch (ProgramSelect)
            {
                case 1:
                    {
                        maths.Addition(); break;
                    }
                case 2:
                    {
                        maths.Subtraction(); break;
                    }
                case 3:
                    {
                        maths.Multiplication(); break;
                    }
                case 4:
                    {
                        maths.Division(); break;
                    }
                case 5:
                    {
                        maths.Root(); break;
                    }
                case 6:
                    {
                        maths.SquareAndCube(); break;
                    }
                case 7:
                    {
                        maths.Secret(); break;
                    }
                case 8:
                    {
                        Console.WriteLine("Exiting Program");
                        return;
                    }
                default: Console.WriteLine("Error, Please Enter a valid number to choose a program"); break;
            }
        }
    }
}