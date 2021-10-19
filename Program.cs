using System;
using System.Collections.Generic;

namespace activity_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //Master loop implementation

            int minutesRemaining = 1440;
            List<string> activityList = new List<string>();

            
            do
            {
                Activity activity = new Activity();
                Console.WriteLine("What are you doing currently?");
                string task = Console.ReadLine();

                activity.Task = task;
                activityList.Add(task);

                activity.DoActivity();
                activity.ParseMinutes(ref minutesRemaining);

                Console.WriteLine("Lists of tasks done today:");
                foreach (var item in activityList)
                {
                    Console.WriteLine(item);
                }

                if (minutesRemaining == 0)
                {
                    Console.WriteLine("All the time has been spent for today. Tackle tomorrow.");
                }
            }
            while (minutesRemaining <= 1440);
        }
    }
}
