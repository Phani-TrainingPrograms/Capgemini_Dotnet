using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
   class Computer
    {
        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiscSize { get; set; }
        public int GraphicsCard { get; set; }
    }

    class Desktop : Computer
    {
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }

        public double DesktopPrice()
        {
            Console.WriteLine("Do UR calculations for Desktop");
            return RamSize;
        }
    }

    class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }
    }
    internal class Practise
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.GraphicsCard = 1;
            computer.HardDiscSize = 112313121;
            computer.RamSize = 64;
        }
    }
}
