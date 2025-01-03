using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex03DataTypes
    {

        /// <summary>
        /// This function shall return data of the type specified in the arg.
        /// </summary>
        /// <param name="type">The type of data U should return</param>
        /// <returns>A value of the specified type that is passed as arg</returns>
        static object GetResult(string type)
        {
            if (type == "string")
            {
                return "Hello world";
            }
            else if (type == "int")
            {
                return 123;
            }
            else if (type == "float")
            {
                return 123.45f;
            }
            else if (type == "double")
            {
                return 123.45;
            }
            else
            {
                return null;
            }
        }
        static void Main()
        {
            object value = 123;//BOXING
            //unbox:
            int tempVal = (int)value; //Explicit casting.
            tempVal =Convert.ToInt32(value);                         
            tempVal += 234;
            value = tempVal;
            ////////////Calling the function///
            value = GetResult("string");
            if (value is string)
            {
                string str = value as string;
                Console.WriteLine($"The Value is {str.ToUpper()}");
            }
            else
            {
                Console.WriteLine("The value is accepted");
            }

        }       
    }
}
