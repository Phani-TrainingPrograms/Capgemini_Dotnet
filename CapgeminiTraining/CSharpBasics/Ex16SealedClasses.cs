using System;
//Sealed Classes are classes that are not intended to inherit. 
//Concrete classes are created to avoid further inheritance. 
//Framework based classes usually are sealed. String is a sealed class. 
//It is against the principle of OOP. 
//Sealed classes cannot have virtual methods, abstract methods in them.
namespace CSharpBasics
{
    sealed class SampleClass
    {
        public void TestFunc() => Console.WriteLine("Test Func");
    }

    //class NewSampleClass : SampleClass { }
    internal class SealedClasses
    {
        static void Main(string[] args)
        {
            SampleClass cls = new SampleClass();
            cls.TestFunc();
        }
    }
}
