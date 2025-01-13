using System;
using System.IO;
using System.Linq;
using System.Text;

/*
 * Opposite of Constructors is Destructor. It is called when the object is destroyed. 
 * U cannot destroy an object explicitly in C#. They are destroyed using Garbage Collector, a feature of .NET Framework to manage the memory. 
 * GC ensures that there is enough memory all the time when the objects are created. 
 * If UR APIs have any calls made to the unmanaged code(Traditional C/C++ Code) which needs explicit object destruction, then U can implement an interface called IDisposable and call the Dispose method in UR managed Code(C# code) explicitly so that n memory leaks happen. 
 */
namespace CSharpBasics
{
    class SampleClassForDestructor : IDisposable
    {
        private readonly string _name;
        public SampleClassForDestructor(string name)
        {
            _name = name;
            Console.WriteLine($" object { name } is created ");
        }

        //Syntax for destructor. Dont have access specifiers and no parameters. 
        ~SampleClassForDestructor()
        {
            Console.WriteLine($" object is {_name} destroyed ");
        }

        public void Dispose()
        {
            GC.SuppressFinalize( this );
            Console.WriteLine("Call this function to free any C/C++ Destructors");
        }
    }
    internal class DestructorsExample 
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 100; i++)
            {
                using (SampleClassForDestructor cls = new SampleClassForDestructor(i.ToString()))
                {
                    GC.Collect();//Starts a new thread to destroy all the garbage data. 
                    GC.WaitForPendingFinalizers();

                }
            }
            Console.WriteLine("Now the program is ending");
        }
    }
}
