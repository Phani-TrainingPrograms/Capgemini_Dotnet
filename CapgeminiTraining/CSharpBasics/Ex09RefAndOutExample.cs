/*
 * ref and out are used to retain the values passed as args even after the function returns to the caller. 
 * This will facilitate to create functions that can return multiple values from a single call. 
 * ref values are intialized before passing to the function and it cannot guarantee the value.
 * With out parameters, the out value must be assigned inside the function before it returns to the caller.
 */
using System;
using System.Diagnostics;

namespace CSharpBasics
{
    class RefAndOutExample
    {
        static void TestFunc(ref string arg)
        {
            Console.WriteLine("The Arg: " + arg);
            arg = "Changing arg in the function";
        }


        //Example for ref where there ref parameters are initialized before passing to the function.
        static void MathOperation(int ival1, 
                                int iVal2, 
                                ref int iAddval,
                                ref int iSubVal,
                                ref int iMulval,
                                out double iDivVal)
        {
            iAddval = ival1 + iVal2;
            iSubVal = ival1 - iVal2;
            iMulval = ival1 * iVal2;
            if (iVal2 != 0)
            {
                //as iDivVal is out parameter, the function must assign some value to it before it returns to the caller. 
                iDivVal = ival1 / iVal2;
            }else
            {
                iDivVal = 0;
            }
        }
        static void Main(string[] args)
        {
            string arg = "Apple123";
            TestFunc(ref arg);
            Console.WriteLine("The Arg value after the function call: " + arg);

            //Calling Mathoperation:
            int addedVal= 0, subval = 0, mulVal = 0 ;
            double divVal;
            MathOperation(123,23, ref addedVal, ref subval, ref mulVal, out divVal);
            Console.WriteLine($"The Added value: {addedVal}\nThe Subtracted Value: {subval}\nThe multiplied value: {mulVal}");

            double squareArea, rectArea, rhmArea;
            CalculateArea(13, 12, out squareArea, out rectArea, out rhmArea);
            //display the values using Console.WriteLine.
        }

        //Example for out parameter where the out parameter is expected as a output from the function, hense we dont initialize it before passing to the function
        static void CalculateArea(int length, int height, out double areaOfSquare, out double areaOfRectange, out double areaOfRhombus)
        {
            areaOfRectange = length * height;
            areaOfSquare = length * length;
            areaOfRhombus = 0.5 * areaOfRectange;
        }
    }
}