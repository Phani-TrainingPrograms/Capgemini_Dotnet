using System;
using System.Collections.Generic;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World on the Console");
            Console.WriteLine("My name is Phani raj B.N.");
            Console.WriteLine("I am a trainer in .NET");
            Console.WriteLine("I stay in Bangalore");

            var name = "Phaniraj";
            var address = "Bangalore";
            var age = 48;
            Console.WriteLine("My Name is " + name);

            Console.WriteLine("The Name is {0}. Mr.{0} is from {1} and is aged {2}", name, address, age); //Old syntax
            Console.WriteLine($"My Name is {name}");//New interpolation Syntax. 
        }
    }

}
