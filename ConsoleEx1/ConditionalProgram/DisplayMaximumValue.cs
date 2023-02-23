using System;

namespace ConsoleEx1.ConditionalProgram
{
    internal class DisplayMaximumValue
    {
        public void DisplayMaxValue()
        {
            Console.WriteLine("Please enter first number.");
            var number1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter second number.");
            var number2 = Convert.ToInt16(Console.ReadLine());

            var max = number1 > number2 ? number1 : number2;
            Console.WriteLine($"Max number is {max}");
        }
    }
}
