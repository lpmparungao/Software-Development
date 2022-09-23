using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINEAR EQUATION \n");
            Console.WriteLine("2x + 4.5 = 0 \n");

            float co1 = 2;
            float co2 = 4.5f;
            Console.WriteLine("coefficient 1: " + co1);
            Console.WriteLine("coefficient 2: " + co2);
            Console.Write("\n");
            Console.WriteLine("Solution: x = (-{0}) / {1} \n", co2, co1);
            float x = -co2 / co1;
            Console.WriteLine("x = " + x);
            Console.ReadKey(true);

        }
    }
}
