using System;

namespace CSharpBasics
{
    internal class Ex02ConsoleIO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            var name = Console.ReadLine();
            Console.WriteLine($"The name entered is {name}");

            //Todo: Add few more variables like age, address, and salary and take inputs from the User and display the inputs on the Console. 
        }
    }
}
