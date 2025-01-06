/* NOTES on Data types
 * C# data types are based on CTS of .NET Framework. 
 * All primitive data types come under Value types. Here the variables will hold the value in them. 
 * Classes, Strings, Arrays are reference types where the values store their address/location insteads of their value. The values are created in the HEAP region of the OS.
 * Generally, structs are value types and classes are reference types.
 * object is the universal data type of .NET. It is a reference type. object can store any kind of data in it. We use object type if we dont know the type of the data at compile time. 
 * All primitive types have a struct that contains some constant members and functions to perform conversions from string to its type or for any other generic reasons. 
 * In Value types:
 * integral types: byte, short, int, long.
 * floating types: float, double, decimal
 * other types: bool,char
 * User defined types: struct, enums, DateTime.
 * From C# 7.0, there has been new additions like Tuples and multiple return value Unions.
 * When converting the types, U have some following rules:
 * There can be implicit conversion and explicit conversion. 
 * Converting smaller range types to the larger type is implicit. 
 * However, the reverse needs an explicit casting which can be achieved using C Style casting or using Convert class. C style casting is not safe, better to use Convert class that was introduced in C# 3.0. 
 */

using System;

namespace CSharpBasics
{
    //The classname need not be the same as the file name. However, it is recommended to have the same for better maintenance. 
    class DataTypesDemo
    {
        
        static void Main(string[] args)
        {
            //DataTypeExample();
            //ConversionExample();
            UnsafeCastingExample();
        }
        //This example is used to demo on understanding why C style casting is unsafe. 
        private static void UnsafeCastingExample()
        {
            int ivalue = 2234343;
            long lValue = ivalue;
            checked //older code to check for Arithematic Overflow. 
            {
                ivalue = (int)lValue + int.MaxValue;
            }
            //ivalue = Convert.ToInt32(lValue + int.MaxValue);
            Console.WriteLine($"The int Value is {ivalue} and the longValue is {lValue}");
        }

        //This example is used to demo on converting inputs from the User to the specific data types. 
        private static void ConversionExample()
        {
            Console.WriteLine("Enter the Age");
            string ageValue = Console.ReadLine();
            Console.WriteLine("The Age is " + ageValue);
            //Convert the value to int. 
            int age = int.Parse(ageValue);
            //There is also another class called Convert that can be used to perform conversion from one type to any other type. It is more safer compared to Parse. 
            age = Convert.ToInt32(ageValue);//Use this as alternative. 

            //I want to calculate the no of years left for my retirement. 
            Console.WriteLine("The No of Years left for UR Retirement is " + (50-age));
        }

        private static void DataTypeExample()
        {
            //use integer:
            int firstValue = 123;
            int secondValue = 234;
            //use long
            long result = firstValue + secondValue;
            //float value:
            float fValue = 123.45f;//f signifies that it is a float, else it would be double. 
            decimal dValue = decimal.MaxValue;
            //Other types:
            char val = 'a';//Use single quotes for chars...
            bool isPossible = true;// value could be true of false. Its case sensitive.
            //date Time:
            DateTime dt = DateTime.Now;//Gives the System date and Time. 
            Console.WriteLine($"The Date today is {dt.ToLongDateString()}");
            //Extracting the parts of the datetime:
            int year = dt.Year;
            int month = dt.Month;
            int day = dt.Day;
            Console.WriteLine($"The date is {day}/{month}/{year}");
            //todo: I want the date to be displayed as dd/MM/yyyy. Today's date should be displayed as 06/01/2025.
        }
    }
}