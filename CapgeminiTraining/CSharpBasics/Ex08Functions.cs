﻿/*
 * Functions are blocks of code that are creaeted for reusability and modularity.
 * They are defined within the class or struct can be invoked to reuse the code and simplify the maintenance.
 * 
 * Functions have access specifiers to allow various restriction leves while accessing them:
 * private: Only within the class it is declared.
 * public: Across the Application and solution. 
 * protected : Within the Class and its derived classes. 
 * internal : Available only within the Project.
 * protected-internal/private-protected: Combinations.
 * 
 * Return Type: Functions have either void or data types specified. functions can return only one kind of data. However, from C# 8.0 we can have functions that return Union data (int, long) likewise.
 * 
 * Parameters: Functions usually have parameters that are created to inject the dependencies required for the function to compute smoothly. There can be required, optional, out, ref parameters.
 * 
 * Functions can be static or non static. Static Functions are created to invoke them without the necessity of object creation. Usually used for frequently used functions. 
 * Non static functions need object creation and are creaeted to operate with the data of the classes. 
 
 * Functions can be invoked either synchronously or asynchronously, but should be decided at the time of function creation itself. However, U can use multi threading concepts to invoke the methods asynchronously.  
 */

using System;

namespace CSharpBasics
{
    class FunctionsDemo
    {
        const string TITLE = "Math Calc Program";

        static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();  
        }
        static int GetValue(string question)
        {
            string answer = GetString(question);
            return Convert.ToInt32(answer);
        }
        static void Main(string[] args)
        {
            bool processing = false;
            Console.Title = TITLE;
            do
            {
                Console.Clear();
                int firstVal = GetValue("Enter the First value: ");
                int secondVal = GetValue("Enter the Second value: ");
                string choice = GetString("Enter the choice as +, - or * or /");
                double result = ProcessChoice(firstVal, secondVal, choice);
                Console.WriteLine("The Result of this Operation is " + result);
            } while (GetString("Press Y to continue").ToUpper() == "Y");
        }

        private static double ProcessChoice(int firstVal, int secondVal, string choice)
        {
            double result = 0.0;
            switch (choice)
            {
                case "+": result = firstVal + secondVal; break;
                case "-": result = firstVal - secondVal; break;
                case "*": result = firstVal * secondVal; break;
                case "/": result = firstVal / secondVal; break;
                default:
                    break;
            }

            return result;
        }
    }
}