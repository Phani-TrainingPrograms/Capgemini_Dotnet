using System;
/*Notes on Console IO
 * Console is a static class that is used to perform IO operations on Console Window.
 * Console.WriteLine function is used to write text on the Console Window.
 * Console.ReadLine function is used to take input from the Console Window. It always returns string.
 * What is the difference b/w Read and ReadLine methods. 
 * What is the difference b/w the Write and WriteLine methods. 
*/
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
