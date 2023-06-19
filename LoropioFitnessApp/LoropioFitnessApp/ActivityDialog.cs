using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class ActivityDialog
    {
<<<<<<< HEAD


        string[] validActivities = new string[4] { "1", "2", "3", "4" };

=======
>>>>>>> 7c3d23eb8648bfbbcbb68d9b54bf61d2d1e13a6e
=======
>>>>>>> 7c3d23eb8648bfbbcbb68d9b54bf61d2d1e13a6e
        public static void EnterActivity()
        {
            Console.WriteLine("What type of sports activity do you want to enter ?");
            Console.WriteLine("1. Bike SportActivity");
            Console.WriteLine("2. Climb SportActivity");
            Console.WriteLine("3. Run SportActivity");
            Console.WriteLine("4. Swim SportActivity");
            string activityName = Console.ReadLine();

<<<<<<< HEAD
            Console.WriteLine("Enter the total distance covered on the activity in KM");
=======
            Console.WriteLine("Enter the total distance covered on the activity");
            string distanceCovered = Console.ReadLine();
            double distance = double.Parse(distanceCovered);

            Console.WriteLine("Enter the total time spent on the activity in the format HH:MM:SS");
            string timeTaken = Console.ReadLine();
            TimeOnly time = TimeOnly.Parse(timeTaken);

            Console.WriteLine("Enter the date of the activity in the format MM/DD/YY");
            string dateOfActivity = Console.ReadLine();
            DateOnly date = DateOnly.Parse(dateOfActivity);

            double averageSpeed = SportActivity.CalculateAverageSpeedInKmPerHour(distance, time);


            Console.WriteLine("How did you feel after the activity: ");
            Console.WriteLine("1. BAD");
            Console.WriteLine("2. OK");
            Console.WriteLine("4. GOOD");
            Console.WriteLine("5. VERY GOOD");
            Console.WriteLine("6. STRONG");
            string afterActivityFeeling = Console.ReadLine();

            switch (afterActivityFeeling)
            {
                case "1":
                    Console.WriteLine("BAD");
                    break;
                case "2":
                    Console.WriteLine("OK");
                    break;
                case "3":
                    Console.WriteLine("GOOD");
                    break;
                case "4":
                    Console.WriteLine("VERY GOOD");
                    break;
                default:
                    Console.WriteLine("STRONG");
                    break;
            }

            Console.WriteLine("\nName of the activity: " + activityName +
            "\nDistance covered: " + distance + " kilometers" +
            "\nTimeTaken: " + time +
            "\nDate of activity: " + date +
            "\nHow You Felt After the Activity: " + afterActivityFeeling +
            "\nAverage speed: " + averageSpeed + " KM/h");
        }
    }
}
