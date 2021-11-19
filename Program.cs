using System;
using System.Collections.Generic;

namespace activity_tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quitApp = false;
            int minutesRemaining = 1440;
            List<Activity> activityList = new List<Activity>();

            Console.WriteLine("**** There are 1440 minutes in a day. This application's purpose is to help you maximize your productivity by planning out what you want to do for the day and how much time you want to spend on it. ****");
            do
            {
                Console.WriteLine("Please select an option below by typing in the appropriate number and hitting enter \n 1: Add a task \n 2: View all planned tasks \n 3: See how much time is left in the day \n 4: Quit");
                var selectedOption = Console.ReadLine();
                Console.WriteLine();

                switch (selectedOption)
                {
                    case "1":
                        GenerateTask(activityList, ref minutesRemaining);
                        break;
                    case "2":
                        ViewTasks(activityList);
                        break;
                    case "3":
                        DisplayTime(ref minutesRemaining);
                        break;
                    case "4":
                        quitApp = true;
                        break;
                    default:
                        Console.WriteLine("Invalid response. Try again.");
                        break;
                }
            }
            while (!quitApp && minutesRemaining != 0);

            if (minutesRemaining == 0)
            {
              
                Console.WriteLine("Wow! You were able to plan out the whole day. Let's do it again tomorrow.");
              
            }
        }

        private static void DisplayTime(ref int minutesRemaining)
        {
            Console.WriteLine($"There are {minutesRemaining} minutes remaining left in the day for other activities.");
            Console.WriteLine(); 
        }

        private static void GenerateTask(List<Activity> activityList, ref int minutesRemaining)
        {
            Activity activity = new Activity();
            Console.WriteLine("What would you like to do today?");
            string task = Console.ReadLine();

            Console.WriteLine();

            activity.Task = task;

            if (activity.ParseMinutes(ref minutesRemaining) >= 0)
            { activityList.Add(activity); }
        }

        private static void ViewTasks(List<Activity> activityList)
        {
            Console.WriteLine("Lists of tasks planned for today:");

            foreach (var item in activityList)
            {
                Console.WriteLine($"{item.Task}: {item.TimeSpent} minutes");
            }
            Console.WriteLine();
        }

    }
}
