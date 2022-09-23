using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("TOTAL CALORIES BURNED \n");
            Console.WriteLine("Running 6 MPH");
            Console.WriteLine("Playing basketball for 30 minutes");
            Console.WriteLine("Sleeps for 6 hours \n");

            double mph = 9.5 / 1.609;
            double onemph_met = 10 / mph;
            float sixmph_met = (float)onemph_met * 6;
            int bball_met = 8;
            int sleep_met = 1;
            int weight = 70;
            int min_run = 30;
            int min_bball = 30;
            int min_sleep = 360;

            float burned_running = (float) 0.0175 * sixmph_met * weight * min_run;
            float burned_basketball = (float) 0.0175 * bball_met * weight * min_bball;
            float burned_sleeping = (float) 0.0175 *sleep_met * weight * min_sleep;

            float total_cal = burned_running + burned_basketball + burned_sleeping;
            Console.WriteLine("Total Calories Burned in Running: {0}", burned_running);
            Console.WriteLine("Total Calories Burned in Running: {0}", burned_basketball);
            Console.WriteLine("Total Calories Burned in Running: {0} \n", burned_sleeping);
            Console.WriteLine("Total Calories Burned: {0}", total_cal);

            Console.ReadKey(true);
        }
    }
}
