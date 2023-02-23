using System;

namespace ConsoleEx1.ConditionalProgram
{
    internal class UserInputValidation
    {
        public void ValidateInput()
        {
            Console.WriteLine("Please enter a number between 1 to 9.");
            var userInput = Console.ReadLine();
            var number = Convert.ToInt16(userInput);
            var output = (number > 0 && number < 10) ? "Input Validated." : "Input is Invalid.";
            
            Console.WriteLine(output);
        }
    }
}
