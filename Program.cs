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

            Console.WriteLine("**** There are 1440 minutes in a day and this app's purpose is to help you maximize your productivity by planning out what you want to do for the day and how much time you want to spend on it. ****");
            do
            {
                Console.WriteLine("Please select an option below \n 1: Add a task \n 2: View all planned tasks \n 3: See how much time is left in the day \n 4: Quit");
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
                        Console.WriteLine($"There are {minutesRemaining} minutes remaining left in the day. \n");
                        break;
                    case "4":
                        quitApp = true;
                        break;
                    default:
                        Console.WriteLine("Invalid response. Try again.");
                        break;
                }
            }
            while (!quitApp);

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
