using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Ex26MulticastDelegateExample
    {
        static void displayMessage(string message) => Console.WriteLine(message);
        static void displayMessage2(string message) => Console.WriteLine(message.ToUpper());

        static void Main()
        {
            Action<string> notify = new Action<string>(displayMessage);
            notify += displayMessage2;
            notify += (msg) => Console.WriteLine(msg.ToLower());

            notify("Welcome to delegates");

            Func<int, int, double> mathFunc = (v1, v2) => v1 + v2;
            mathFunc += (v1, v2) => v1 - v2;
            mathFunc += (v1, v2) => v1 * v2;
            mathFunc += (v1, v2) => v1 / v2;
            var functions = mathFunc.GetInvocationList();
            for (int i = 0; i < functions.Length; i++)
            {
                var result = functions[i].DynamicInvoke(13, 12);
                Console.WriteLine("The result is : " + result);
            }
            //Console.WriteLine("The result: " + mathFunc(13,12));
        }

    }
}
