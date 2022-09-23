using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DAY OF THE WEEK \n");
            Console.WriteLine("ENTER THE DATE");
            Console.WriteLine("i.e. January 1, 2020. Month = 1, Day = 1, Year = 2020\n");
            Console.Write("Month: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            int y = year % 100;
            int c = year / 100;
            int x = y % 4;


            if (m == 2 && day == 29 && x != 0)
            {
                Console.WriteLine("Error. February 29 but not Leap year");
            }

            if (m < 3)
            {
                m += 12;
                y--;
            }
            if (m > 12)
            {

            }
            else
            {

            }

            while (true)
            {
                int d = (day + ((13 * (m + 1)) / 5) + (y) + (y / 4) + (c / 4) + (5 * c)) % 7;

                if (d == 0)
                {
                    Console.WriteLine("\nThe Day of the Week is Saturday");
                }
                if (d == 1)
                {
                    Console.WriteLine("\nThe Day of the Week is Sunday");
                }
                if (d == 2)
                {
                    Console.WriteLine("\nThe Day of the Week is Monday");
                }
                if (d == 3)
                {
                    Console.WriteLine("\nThe Day of the Week is Tuesday");
                }
                if (d == 4)
                {
                    Console.WriteLine("\nThe Day of the Week is Wednesday");
                }
                if (d == 5)
                {
                    Console.WriteLine("\nThe Day of the Week is Thursday");
                }
                if (d == 6)
                {
                    Console.WriteLine("\nThe Day of the Week is Friday");
                }
                Console.ReadKey(true);
            }
        }
    }
}
