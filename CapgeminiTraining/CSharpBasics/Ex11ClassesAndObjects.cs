using System;
using System.Runtime.InteropServices;
/*
 * A Class is a user defined type(UDT) which is like a composition of multiple data types represented as single unit that is relatable to the real world entity
 * A Class is a reference type in .NET. 
 * A Class is comprised of fields(data of the class), methods(functions of the class that are created to manipulate the data), properties(Accessors to the fields), events(actions that can be performed on the object) and some times, nested class.
 * Usually the data of the class is private(hidden to the outside world). 
 * To manipulate the data, we have accessors or Functions. 
 * Fields are now obelete. Instead we use properties.
 * However, if U want data that has to have some business rules in it, we still recommend to use fields and access them with functions.
 * Functions are expected to be modular in nature. If U have a funtion logic that is too large, then U can break apart the function into smaller units, where there is a logical seperation for each unit. The smaller units are made private as they are not required to be directly used to the Application. They are called as private methods.
 * Private methods are expected to be used by the public methods. This provides a feature called Abstration. The interal features are experienced but not seen directly. 
 * internal is used if U want the class or the method to be available within the project(Assembly).  At the class level, U can have either internal or public. default is internal. 
 * Within the class, members are private by default. U can have other access specifiers like public, internal, protected internal or private internal
 * Generally, data is private and we use functions to manipulate the data. It could be set, get, update, add etc. 
 * The data for an instance is unique to itself. however, if U want to share the data among the objects, then U can make a static member and refer it thru any object using its class name. static members are singleton and they are always refered using the classname. 
 * instance members can call the static members either directly if it is in the same class or thru the classname if it is outside the class. However, the reverse is not possible. Static members cannot call instance members without an object creation even if it is in the same class. 
 * U should create static methods if those methods are frequently used across the Application at various locations or points. It is recommended to create seperate class for having static methods and use them. U can also restrict from creating an instance by making the class static. 
 */

namespace CSharpBasics
{
    class TestClass
    {
        //intended to be used within the class. Probably by the public methods
        private void PersonalFn() => Console.WriteLine("My Personal Func");
        public void TestFn() 
        {
            Console.WriteLine("Test Func");
            PersonalFn();
        }
    }
 
    class ExpenseManager
    {
        private double amount;

        static string Title = string.Empty;
        public ExpenseManager(double amount)
        {
            this.amount = amount;
        }

        public void AddAmount(double amount) => this.amount += amount;

        public double GetBalance() => amount;

        public void MakePayment(double amount)
        {
            if (amount > this.amount)
            {
                throw new Exception("Insufficient Funds");
            }
            this.amount -= amount;
        }

        public void SetTitle(string title)
        {
            ExpenseManager.Title = title;
        }
        public void DisplayTitle() => Console.WriteLine(ExpenseManager.Title);
            

    }
    internal class ClassesAndObjects
    {
         static void Main(string[] args)
        {
            TestClass instance = new TestClass();
            instance.TestFn();

           
            Console.WriteLine("Enter the Amount to start with:");
            double amount = double.Parse(Console.ReadLine());
            ExpenseManager manager = new ExpenseManager(amount);
            manager.SetTitle("Trip Expense Manager");
            //Console.WriteLine("Enter the Amount to pay to Hotel.com");
            //amount = double.Parse(Console.ReadLine());
            //manager.MakePayment(amount);
            //Console.WriteLine("Enter the person name or UPI id to make the payment");
            //string person = Console.ReadLine();
            //Console.WriteLine($"Enter the Amount to pay to {person}");
            //amount = double.Parse(Console.ReadLine());
            //manager.MakePayment(amount);
            //Console.WriteLine("Enter the Amount to pay to Hotel.com");
            //amount = double.Parse(Console.ReadLine());
            //manager.MakePayment(amount);

            ExpenseManager foodExp = new ExpenseManager(10000);
            foodExp.SetTitle("Food Expenses");
            foodExp.DisplayTitle();
            manager.DisplayTitle();

        }
    }
}
