/*Enums:
 * They are named Constants. To represent integral values, instead of numbers, it could be names which are grouped into an unit called Enum. They are refered by their EnumName and the named Constant.
 * Enums are widely used to take inputs from a range of specific values represented by strings but internally hold integral values. 
 * Enums are user defined types. As they hold integral values, they are value types. 
 */

using System;
using System.Text;

namespace CSharpBasics
{
    enum WeekOfDay
    {
        Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }

    class EnumsExample
    {
        static void Main(string[] args)
        {
            //FirstDemo();
            ExampleWithInputs();
        }

        private static void ExampleWithInputs()
        {
            Console.WriteLine("Enter the day of the week U want to take off from the list below:");
            Array values = Enum.GetValues(typeof(WeekOfDay));
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            string input = Console.ReadLine();
            //Should convert the string to the WeekDay Type. 
            WeekOfDay selectedDay = (WeekOfDay)Enum.Parse(typeof(WeekOfDay), input, true); //use true to ignore the case while taking the input. 
            Console.WriteLine("The Selected Day is " + selectedDay);

            selectedDay = (WeekOfDay)3;
            Console.WriteLine("The selected Day is " + selectedDay);
        }

        private static void FirstDemo()
        {
            WeekOfDay day = WeekOfDay.Tuesday;
            Console.WriteLine($"The selected day is {day}");
            Console.WriteLine($"The internal value is {(int)day}");
            Console.WriteLine("The data type of the Enum value is " + day.GetType().Name);
            Console.WriteLine("The internal Data type of the value is " + day.GetTypeCode());
        }
    }
}