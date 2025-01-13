using System;
using System.Collections.Generic;
using System.Data;
/*
 * Constructors are sp fns created to provide DI (Dependency Injection) feature to the objects of the class when they are created. 
 * It is used to initialize the object. 
 * As it is like function, it can be parameterised and overloaded. It is implicitly called when an object is created and is used to setup the initial states or inject any data that UR object is dependent upon. 
 * Constructors created with no  parameters are called as Default constructors. It is good to have one.
 * U can also have parameterised contructors. 
 * Static constructors are created to initialize static variables. It can also be used to execute a block of code even before any reference of the class is done in the program. It will be called once and only once during the execution of the Program. U cannot call static constructors explicitly. They dont have any parameters or even access specifiers. 
 * 
 */
namespace CSharpBasics
{

    class ConstructorClass
    {
        static ConstructorClass() => Console.WriteLine("Static constructor");

        public ConstructorClass() => Console.WriteLine("Normal Constructor");

    }
    class EmpDatabase
    {
        private List<string> _employees;
        
        public EmpDatabase(int initialSize = 1)
        {
            _employees = new List<string>(initialSize);
        }
        public void AddEmployee(string employee)
        {
            _employees.Add(employee);
        }
    }
    internal class Ex19Constructors
    {
        static Ex19Constructors()
        {
            Console.WriteLine("Executed even before Main");
        }
        static void Main(string[] args)
        {
            //EmpDatabase empDatabase = new EmpDatabase(5);
            //var emp = "123, Phaniraj, Bangalore";
            //empDatabase.AddEmployee(emp);
            //Console.WriteLine("Employee added successfully to the database");
            StaticConstructorsDemo();
        }

        private static void StaticConstructorsDemo()
        {
            //Note: Static constructor is called only once.
            for (int i = 0; i < 19; i++)
            {
                //called so many no of times. 
                ConstructorClass cls = new ConstructorClass();
            }
        }
    }
}
