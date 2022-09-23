using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PERIMETER AND AREA OF A TRIANGLE \n");
            Console.WriteLine("ENTER THE PARAMETERS \n");
            Console.Write("Side 1: ");
            float side1 = float.Parse(Console.ReadLine());
            Console.Write("Side 2: ");
            float side2 = float.Parse(Console.ReadLine());
            Console.Write("Side 3: ");
            float side3 = float.Parse(Console.ReadLine());

            float perimeter = side1 + side2 + side3;
            float s = perimeter / 2;
            float area = (float) Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));

            Console.WriteLine("The Perimeter of the triangle is: {0}m\nThe Area of the triangle is: {1}m\u00b2", perimeter, area);
            Console.ReadKey(true);



        }
    }
}
