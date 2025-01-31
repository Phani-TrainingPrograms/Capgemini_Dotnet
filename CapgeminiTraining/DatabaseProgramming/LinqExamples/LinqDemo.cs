using DatabaseProgramming.Data;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DatabaseProgramming.LinqExamples
{
    internal class LinqDemo
    {
        static void Main(string[] args)
        {
            //stringLinqExample();
            exampleOfList();
        }

        private static void exampleOfList()
        {
            var component = new EmployeeDbAccess();
            var list = component.GetAll();
            var names = from emp in list
                        select emp.DeptId;
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
        }

        private static void stringLinqExample()
        {
            var text = "Apple123";//string is a colletion of charecters, so its a collection object. 

            var charecters = from ch in text
                                 //where, orderby groupby
                             select ch;

            text += " is a simple Example for text";
            //Every LINQ query shall return an IEnumerable < T > object.
            foreach(var ch in charecters)
            {
                Console.WriteLine(ch);
            }
        }
    }
}
