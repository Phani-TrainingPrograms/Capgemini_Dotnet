using System;
//Delegates are reference types that can be used to create references for the methods that could be passed as arguments or parameters and invoke them dynamically. Similar to function pointers of C/C++.
//It is more like Type safe Function pointer.
//If there is a requirement to invoke a method that is passed as parameter to UR function. How can U do this?
//Delegate instance can be mapped to any method that matches the signature of the delegate
//.NET gives 2 important delegates called Action and Func. Action is for void Functions and Func is for non-void Functions. 
namespace CSharpBasics
{
    delegate double MyMethod(int first, int second);
    internal class Ex25DelegatesExample
    {
        static void InvokeSquareFuncs(double arg, Func<double, double> func)
        {
            var result = func(arg);
            Console.WriteLine("The Result: " + result);
        }
        static void InvokeUsingFunc(int first, int second, Func<int, int, double> method)
        {
            //Check all business rules.
            var result = method(first, second);
            Console.WriteLine("The result: " + result);
        }
        static void InvokeArithematicMethod(int iVal1, int iVal2, MyMethod method)
        {
            //Check all business rules.
            var result = method(iVal1, iVal2);
            Console.WriteLine("The result: " + result);
        }
        static double addFunc(int v1, int v2) => v1 + v2;
        static void Main(string[] args)
        {
            //MyMethod func = new MyMethod(addFunc); ==>1st version
            //InvokeArithematicMethod(123, 23, addFunc); ==>2nd version
            //InvokeArithematicMethod(123, 23, (a1, a2) => a1 * a2);
            
            Func<int, int, double> myFunc = new Func<int, int, double>((i1, i2) =>
            {
                return i1 + i2;
            });
            InvokeUsingFunc(123,23, myFunc);
            //Try using the func delegate for calling Square and Squareroot  methods => take double and rturn double. 

            Func<double, double> sqr = new Func<double, double>((d1) => d1 * d1);
            InvokeSquareFuncs(12, sqr);

        }
    }
}
