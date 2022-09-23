using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRICES AND TOTAL OF THREE ITEMS \n");
            Console.WriteLine("ENTER THE PRICES OF THREE ITEMS: \n");
            Console.Write("Item 1: ");
            int item1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Item 2: ");
            int item2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Item 3: ");
            int item3 = Convert.ToInt32(Console.ReadLine());


            int new1 = (item1 + 5);
            int new2 = (item2 + 5);
            int new3 = (item3 + 5);
            int total = (new1 + new2 + new3);

            Console.WriteLine("\n");
            Console.WriteLine("New Prices: \n");
            Console.WriteLine("Item 1: {0} \nItem 2: {1} \nItem 3: {2}\n ", new1, new2, new3);
            Console.WriteLine("Total:" + total);

            Console.ReadKey(true);
        }
    }
}
