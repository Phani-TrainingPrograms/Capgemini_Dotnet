using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Multiply(int a, int b) => a * b;
        public int Divide(int a, int b)
        {
            if(b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }

}
