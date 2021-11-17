using System;
namespace activity_tracker
{
    public class Activity
    {
        public string Task { get; set; }
        public int TimeSpent { get; set; }

        public int ParseMinutes(ref int minutesRemaining)
        {
            Console.WriteLine($"How much time do you want to allocate for this task? (in minutes)");
            var minutes = Console.ReadLine();
            Console.WriteLine();

            int.TryParse(minutes, out int parsedMins);

            TimeSpent = parsedMins;

            if (parsedMins > minutesRemaining)
            {
                Console.WriteLine("Silly goose, you can't spend more time than there is left in the day!");
                Console.WriteLine();
            }
          
            else
            {
                decimal i = parsedMins;
                Console.WriteLine($"You plan on spending {parsedMins} minutes or {i / 60} hours for {Task}.");
                Console.WriteLine();
            }

            return minutesRemaining -= parsedMins;

        }

        
    }
}
