using LoropioFitnessApp.Activity;
using LoropioFitnessApp.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class ActivityDialog
    {
        public static void EnterActivity()
        {

            string[] validActivities = new string[4] { "1", "2", "3", "4" };

            Console.WriteLine("What type of sports activity do you want to enter ?");
            Console.WriteLine("1. Bike SportActivity");
            Console.WriteLine("2. Climb SportActivity");
            Console.WriteLine("3. Run SportActivity");
            Console.WriteLine("4. Swim SportActivity");

            string activityTypeInput = Console.ReadLine();

            ActivityType activityType;


            if (activityTypeInput == null)
            {
                return;
            }

            activityType = (ActivityType)(int.Parse(activityTypeInput));

            OpenActivityDialog(activityType);
        }

        private static void OpenActivityDialog(ActivityType activityType)
        {
            switch (activityType)
            {
                case ActivityType.Running:
                    AddRunActivity(activityType);
                    break;
                case ActivityType.Biking:
                    AddBikeActivity(activityType);
                    break;
                case ActivityType.Climbing:
                    AddClimbActivity(activityType);
                    break;
                case ActivityType.Swimming:
                    AddSwimActivity(activityType);
                    break;
                default:
                    // Do something else.
                    break;
            }
        }

        public static void AddRunActivity(ActivityType activityType)
        {
            Console.WriteLine("Enter the total distance covered on the activity in KM");
            string distanceCovered = Console.ReadLine();
            double distance = double.Parse(distanceCovered);

            Console.WriteLine("Enter the total time spent on the activity in the format HH:MM:SS");
            string timeTaken = Console.ReadLine();
            TimeSpan time = TimeSpan.Parse(timeTaken);

            Console.WriteLine("Enter the date of the activity in the format MM/DD/YY");
            string dateOfActivity = Console.ReadLine();
            DateOnly date = DateOnly.Parse(dateOfActivity);


            Console.WriteLine("How did you feel after the activity: ");
            Console.WriteLine("1. BAD");
            Console.WriteLine("2. OK");
            Console.WriteLine("4. GOOD");
            Console.WriteLine("5. VERY GOOD");
            Console.WriteLine("6. STRONG");
            string afterActivityFeeling = Console.ReadLine();

            Feeling feeling = (Feeling)Enum.Parse(typeof(Feeling), afterActivityFeeling);

            var runActivity = new RunActivity(distance * 1000, time, feeling, date);

            ActivityRespository.Add(runActivity);
            Console.WriteLine("New run Activity created");

        }

        private static void AddBikeActivity(ActivityType activityType)
        {
            Console.WriteLine("Enter the total distance covered on the activity in KM");
            string distanceCovered = Console.ReadLine();
            double distance = double.Parse(distanceCovered);

            Console.WriteLine("Enter the total time spent on the activity in the format HH:MM:SS");
            string timeTaken = Console.ReadLine();
            TimeSpan time = TimeSpan.Parse(timeTaken);

            Console.WriteLine("Enter the date of the activity in the format YYYY/MM/DD");
            string dateOfActivity = Console.ReadLine();
            DateOnly date = DateOnly.Parse(dateOfActivity);


            Console.WriteLine("How did you feel after the activity: ");
            Console.WriteLine("1. BAD");
            Console.WriteLine("2. OK");
            Console.WriteLine("4. GOOD");
            Console.WriteLine("5. VERY GOOD");
            Console.WriteLine("6. STRONG");
            string afterActivityFeeling = Console.ReadLine();

            Feeling feeling = (Feeling)Enum.Parse(typeof(Feeling), afterActivityFeeling);

            var bikeActivity = new BikeActivity(distance * 1000, date, feeling, time);

            ActivityRespository.Add(bikeActivity);
            Console.WriteLine("New Bike Activity created");

        }

        public static void AddClimbActivity(ActivityType activityType)
        {
            Console.WriteLine("Enter the total distance covered on the activity in Meters");
            string distanceCovered = Console.ReadLine();
            double distance = double.Parse(distanceCovered);

            Console.WriteLine("Enter the total time spent on the activity in the format HH:MM:SS");
            string timeTaken = Console.ReadLine();
            TimeSpan time = TimeSpan.Parse(timeTaken);

            Console.WriteLine("Enter the date of the activity in the format MM/DD/YY");
            string dateOfActivity = Console.ReadLine();
            DateOnly date = DateOnly.Parse(dateOfActivity);


            Console.WriteLine("How did you feel after the activity: ");
            Console.WriteLine("1. BAD");
            Console.WriteLine("2. OK");
            Console.WriteLine("4. GOOD");
            Console.WriteLine("5. VERY GOOD");
            Console.WriteLine("6. STRONG");
            string afterActivityFeeling = Console.ReadLine();

            Feeling feeling = (Feeling)Enum.Parse(typeof(Feeling), afterActivityFeeling);

            var climbActivity = new ClimbActivity(distance, time, feeling, date);

            ActivityRespository.Add(climbActivity);
            Console.WriteLine("New Climb Activity created");

        }

        private static void AddSwimActivity(ActivityType activityType)
        {
            Console.WriteLine("Enter the total distance covered on the activity in Meters");
            string distanceCovered = Console.ReadLine();
            double distance = double.Parse(distanceCovered);

            Console.WriteLine("Enter the total time spent on the activity in the format HH:MM:SS");
            string timeTaken = Console.ReadLine();
            TimeSpan time = TimeSpan.Parse(timeTaken);

            Console.WriteLine("Enter the date of the activity in the format MM/DD/YY");
            string dateOfActivity = Console.ReadLine();
            DateOnly date = DateOnly.Parse(dateOfActivity);


            Console.WriteLine("How did you feel after the activity: ");
            Console.WriteLine("1. BAD");
            Console.WriteLine("2. OK");
            Console.WriteLine("4. GOOD");
            Console.WriteLine("5. VERY GOOD");
            Console.WriteLine("6. STRONG");
            string afterActivityFeeling = Console.ReadLine();

            Feeling feeling = (Feeling)Enum.Parse(typeof(Feeling), afterActivityFeeling);

            var swimActivity = new SwimActivity(distance, time, feeling, date);

            ActivityRespository.Add(swimActivity);
            Console.WriteLine("New Swim Activity created");

        }

        public static void DisplayAllActivities()
        {
            Console.WriteLine("********************");
            Console.WriteLine("* Your Activities  *");
            Console.WriteLine("********************");

            var allActivities = ActivityRespository.GetAll();

            foreach (var activity in allActivities)
            {
                Console.WriteLine($"Activity Name:{activity.GetType().Name};");
                Console.WriteLine($"Distance:{activity.Distance};");
                Console.WriteLine($"TimeTaken:{activity.TimeTaken};");
                Console.WriteLine($"Average Speed:{activity.CalculateAverageSpeed() + " " + activity.GetVelocityUnit()};");
                Console.WriteLine($"Feeling:{activity.Feeling};");
                Console.WriteLine($"Date:{activity.Date};");
                Console.WriteLine($"HeartRate:{activity.GetHeartRates()};");
            }

            Console.WriteLine("Press ENTER to continue \n");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { };
            Console.Clear();
        }
    }
}
