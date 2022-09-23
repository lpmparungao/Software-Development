using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AVERAGE GPA \n");
            Console.WriteLine("ENTER THE GPA OF THE THREE STUDENTS: \n");
            Console.Write("Student 1: ");
            float student1 = float.Parse(Console.ReadLine());
            Console.Write("Student 2: ");
            float student2 = float.Parse(Console.ReadLine());
            Console.Write("Student 3: ");
            float student3 = float.Parse(Console.ReadLine());

            float aveGPA = ((student1 + student2 + student3)/3);

            Console.WriteLine("\n");
            Console.WriteLine("Average GPA: " + aveGPA);

            Console.ReadKey(true);
        }
    }
}
