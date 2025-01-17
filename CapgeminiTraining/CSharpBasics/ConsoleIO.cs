using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpBasics
{
    static class ConsoleIO
    {
        /// <summary>
        /// Function to get string input from the user after asking a Question
        /// </summary>
        /// <param name="question">The Question to print</param>
        /// <returns>A string input given by the User.</returns>
        public static string GetString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        /// <summary>
        /// Function to get integer value from the User after asking a Question
        /// </summary>
        /// <param name="question">The Question to print</param>
        /// <returns>A Valid integer.</returns>
        public static int GetValue(string question)
        {
            string answer = GetString(question);
            return Convert.ToInt32(answer);
        }

        public static async Task LoopThru(int times, string message)
        {
            for (int i = 0; i < times; i++)
            {
                await Task.Delay(1000);
                Console.WriteLine(message);
            }
        }
    }
}