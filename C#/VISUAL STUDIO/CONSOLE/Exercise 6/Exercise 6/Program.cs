using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AREA AND VOLUME OF A CIRCLE\n");
            Console.WriteLine("ENTER THE RADIUS \n");
            Console.Write("Radius: ");
            float r = float.Parse(Console.ReadLine());

            float pi = (float)Math.PI;

            float area = 4*pi*r*r;
            float volume = (4 * pi * r * r * r) / 3;
        
            Console.WriteLine("The Area of the circle is: {0}m²\nThe Volume of the circle is is: {1}³ ", area, volume);
            Console.ReadKey(true);
        }
    }
}
