using System;
namespace activity_tracker
{
    public class Activity
    {
        public string Task;

        public void DoActivity()
        {
            Console.WriteLine($"Currently: {Task}");
        }

        public int ParseMinutes(ref int minutesRemaining)
        {
            int parsedMins;

            Console.WriteLine("How many minutes did you spend doing this?");
            var minutes = Console.ReadLine();

            int.TryParse(minutes, out parsedMins);
            Console.WriteLine($"You spent {parsedMins} minutes on {Task}");

            Console.WriteLine($"There are {minutesRemaining -= parsedMins} minutes left in the day.");

            return minutesRemaining;

        }

        
    }
}
