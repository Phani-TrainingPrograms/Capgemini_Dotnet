/*
 * var is a implicitly typed variable that was introducted in C# 3.0. 
 * They are local variables. 
 * They hold the data type of what they are assigned at the time of declaration. 
 * It is only a convinient way of creating local variables.
 * var cannot be used as return type of a function, or a field of a class or a parameter of a method. It is purely used for creating local variables within a function. 
 * var does not perform any  BOXING OR UNBOXING as it directly holds the value and implicitly converts itself to that type.
 * 
 * If U want to create variables whose value has to be determined at runtime and U must avoid the BOXING/UNBOXING feature, then u can use dynamic data type. 
 * Performance wise, it is slightly slower than var. As the value and type info is evaluated at runtime, it has some performance back logs.
 * dynamic can be used as return type of a function or parameter of a function and so forth.
 * Compiler will not have any clue about the data associated with the dynamic object as its evaluated at runtime. 
 */
using System;

namespace CSharpBasics
{
    class VarExample
    {
        static void Main(string[] args)
        {
            varExample();
            objectExample();
            dynamicExample();
        }

        private static void dynamicExample()
        {
            //If a value is assigned with a specific data type whose type is not known to U at compile time, but U dont want to UNBOX or BOX as they are not fast. 
            dynamic value = 123;
            value += 123;
            Console.WriteLine(value);
        }

        private static void objectExample()
        {
            object value;
            value= 123;//Here integer value is BOXED into an object type by name value.
            //To perform any computation, it should be UNBOXED before use.
            int tempVal = (int)value; //UNBOX it
            tempVal += 123; //Manipulate it
            value = tempVal;//Set it back to the value

        }

        private static void varExample()
        {
            var value = 123;
            //value shall become an integer implicitly, hense the name:implicit typed variable

            //value = "Apple 123";//Compile Error as the value is already assigned with int and it shall continue to be int for the lifetime
            value += 123;//No Unboxing done as value is implicitly an integer. 
            Console.WriteLine("The Value is " + value);
        }
    }
}