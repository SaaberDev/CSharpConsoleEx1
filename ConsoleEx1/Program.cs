using System;
using ConsoleEx1.ConditionalProgram;

namespace ConsoleEx1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(@"1. User Input Validation
2. Display Maximum Value
3. Image Display Recognition
");
            Console.WriteLine("=============================");
            Console.WriteLine("Enter a number between 1 to 3");
            var program = Convert.ToInt16(Console.ReadLine());
            switch (program)
            {
                case 1:
                    Console.WriteLine("=============================");
                    Console.WriteLine("Program 1: User Input Validation");
                    // Program 1: User Input Validation
                    // ask user to enter a number between 1 to 9 and validate
                    (new UserInputValidation()).ValidateInput();
                    break;
                case 2:
                    Console.WriteLine("=============================");
                    Console.WriteLine("Program 2: Display Maximum Value");
                    // Program 2: Display Maximum Value
                    // ask user to enter two number and display maximum value entered
                    (new DisplayMaximumValue()).DisplayMaxValue();
                    break;
                case 3:
                    Console.WriteLine("=============================");
                    Console.WriteLine("Program 3: Image Display Recognition");
                    // Program 1: Image Display Recognition
                    // ask the user to enter the width and height of an image and determine image orientation
                    (new ImageDisplayRecognition()).DisplayOrientation();
                    break;
                default:
                    Console.WriteLine("No programs to run!");
                    break;
            }
        }
    }
}