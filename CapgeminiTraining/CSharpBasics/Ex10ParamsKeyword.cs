/* params keyword is used to pass variable number of arguments into a function. 
 * params should be the last of the parameter list. 
 * there can be only one params type in the argument list of the function. 
 * params cannot be passed by ref or out keywords. 
 */

using System;

namespace CSharpBasics
{
    internal class ParamsKeywordExample
    {
        static long AddNumbers(params int[] inputs)
        {
            long result = 0;
            foreach (var input in inputs)
            {
                result += input;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumbers(123));
            Console.WriteLine(AddNumbers(123, 234));
            Console.WriteLine(AddNumbers(123,345,567,4532));
            Console.WriteLine(AddNumbers(123,456,456,456,456,456,565, 645,6));
           Console.WriteLine(AddNumbers(123));
        }
    }
}
