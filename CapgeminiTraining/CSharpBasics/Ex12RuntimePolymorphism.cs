using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{

    class BaseClass
    {
        public virtual void BaseFunc() => Console.WriteLine("Base Version");
    }

    class DerivedClass : BaseClass //inheritance syntax
    {
        public override void BaseFunc() => Console.WriteLine("Derived Version");
    }

    class ObjectFactory
    {
        public static BaseClass Createobject(string objType)
        {
            if (objType == "Base")
            {
                return new BaseClass();
            }
            else if (objType == "Derived")
            {
                return new DerivedClass();
            }
            else
            {
                throw new Exception("Invalid type");
            }
        }
    }
    internal class RuntimePolymorphism
    {
        static void Main(string[] args)
        {
                var answer = ConsoleIO.GetString("Enter the type of object to create");
                var obj = ObjectFactory.Createobject(answer);
                obj.BaseFunc();
        }
    }
}
