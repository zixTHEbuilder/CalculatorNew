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
        int ProgramSelect = input.ReadIntWriteLine("Enter the program you want to use \n1.Addition \n2. Subtraction \n3. Multiplication \n4. Divison \n5. Finding Root \n6. Finding Square/Cube");
        switch (ProgramSelect)
        {
            case 1:
                {
                    maths.Addition();break;
                }
            case 2:
                {
                    maths.Subtraction();break;
                }
            case 3:
                {
                    maths.Multiplication();break;
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
        }
    }
}