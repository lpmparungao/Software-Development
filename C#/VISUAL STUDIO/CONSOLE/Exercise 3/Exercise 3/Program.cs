using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIVISION OF 2 NUMBERS \n");
            Console.WriteLine("a = 18");
            Console.WriteLine("b = 4 \n");

            int a = 18;
            int b = 4;


            int quotient = a / b;
            int remainder = a % b;
            float floatquotient = (float) a / b;

            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            Console.WriteLine("Floating Point: " + floatquotient);

            Console.ReadKey(true);
        }
    }
}
