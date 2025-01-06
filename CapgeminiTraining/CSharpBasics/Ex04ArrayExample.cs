/*
 * Arrays in C# are reference types. 
 * They can be created using new operator. 
 * All arrays are objects of a class called System.Array. 
 * Arrays are fixed in size and are immutable.
 * Its data type and size is determined at compile time itself. 
 * However, .NET Framework allows to create Arrays dynamically with fixed size and type decided at runtime.
 * Limits of Arrays: Even though Arrays are optimized to work on multiple kinds of data, It has certain limitations:
    - As the size is fixed, U cannot dynamically add/remove items from the array. 
    - Not practical on real time scenarios where data has to be extracted from external devices and the data types are not known to us. 
 */
using System;

namespace CSharpBasics
{
    class ArrayExample
    {
        static void Main(string[] args)
        {
            //FirstExample();
            //MultiDimensionalArrayExample();
            //JaggedArrayExample();
            DynamicArrayExample();
            Array array = Array.CreateInstance(typeof(int), 5);
            //Task: Find the difference with example on Array.Copy vs. Array.Clone() and Array.CopyTo()
        }

        /// <summary>
        /// This example domonstrate the Dynamic Array where an Array size and Data type is set at runtime. 
        /// </summary>
        private static void DynamicArrayExample()
        {
            /*
             * Start:
             *   INPUT = Get the size of the array
             *   INPUT = Get the data type(CTS Name)
             *   FOR LOOP:
             *       Take the values from the user. 
             *   OUTPUT:
             *       DISPLAY all the values. 
             */
            Console.WriteLine("Enter the size of the Array");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the CTS Name of the Data type that U want to create the array");
            string type = Console.ReadLine();
            Type dataType = Type.GetType(type, true, true);
            Array instance = Array.CreateInstance(dataType, size);
            Console.WriteLine("Now lets take inputs");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value of the data type {dataType.Name} at the position {i}");
                string value = Console.ReadLine();
                object itemVal= Convert.ChangeType(value, dataType);
                instance.SetValue(itemVal, i);
            }
            Console.WriteLine("All values are set, lets read them");
            foreach(object val in instance)
            {
                Console.WriteLine(val);
            }
        }

        /// <summary>
        /// This example shows on creating Jagged Arrays in C#
        /// </summary>
        private static void JaggedArrayExample()
        {
            //Array of Arrays is called as Jagged Array. Here we have a fixed no of rows and variable no of columns in each row. 
            int[][] classrooms = new int[3][];//3 rows and individual array in each row.
            classrooms[0] = new int[]{ 45,56,55,44 };
            classrooms[1] = new int[] { 88, 65, 66 };
            classrooms[2] = new int[] { 66, 45, 34, 88, 93 };

            Console.WriteLine("Lets read the data and display in matrix format");
            for (int i = 0; i < classrooms.Length; i++)
            {
                Console.WriteLine($"Scores in {i} classroom:");
                foreach (int j in classrooms[i])
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// This example explains the syntax of creating and using multidimensional Array in C#
        /// </summary>
        private static void MultiDimensionalArrayExample()
        {
            int[,] TwodArray = { 
                                    { 1, 2, 3 }, 
                                    { 4, 5, 6 }, 
                                    { 7, 8, 9 } 
                                };
            //Display the array in matrix format.
            //Use nested for loop. 
            Console.WriteLine("The no of dimensions for this Array is " + TwodArray.Rank);
            for (int i = 0; i < TwodArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwodArray.GetLength(1); j++)
                {
                    Console.Write($"{TwodArray[i, j]} ");
                }
                Console.WriteLine();
            }

        }

        /// <summary>
        /// This example shows the basic syntax of Array creation in C#.
        /// </summary>
        private static void FirstExample()
        {
            //data_Type [] variableName = new data_type[size]; 
            Console.WriteLine("Enter the no of elements U wish to have");
            int size = int.Parse(Console.ReadLine());   
            int[] values = new int[size];
            //using for loop to set the values. 
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the position {i}");
                values[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("All values are set!!!\nLets read the data....");
            //foreach loop to iterate thru the values:
            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
            //try creating an array of strings and take inputs of names of UR Collegues in UR row.Display them in the same line seperated by ,.  
        }
    }
}