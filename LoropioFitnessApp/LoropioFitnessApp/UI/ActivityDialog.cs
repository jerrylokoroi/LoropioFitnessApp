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

            var sportActivity = new SportActivity(distance, date, feeling, time);

            var runAcivty = new RunActivity(distance, time, feeling, date);

            Console.WriteLine("Congradulations! You have created a new running activity.");

            Console.WriteLine(
            "\nDistance covered: " + distance + " kilometers" +
            "\nTimeTaken: " + time +
            "\nDate of activity: " + date +
            "\nHow You Felt After the Activity: " + afterActivityFeeling +
            "\nAverage speed: " + sportActivity.CalculateAverageSpeedInKmPerHour()
            +" KM/h");
        }

        public static void AddBikeActivity(ActivityType activityType)
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

            var sportActivity = new SportActivity(distance, date, feeling, time);

            var runAcivty = new RunActivity(distance, time, feeling, date);

            Console.WriteLine("Congradulations! You have created a new biking activity.");

            Console.WriteLine(
            "\nDistance covered: " + distance + " kilometers" +
            "\nTimeTaken: " + time +
            "\nDate of activity: " + date +
            "\nHow You Felt After the Activity: " + afterActivityFeeling +
            "\nAverage speed: " + sportActivity.CalculateAverageSpeedInKmPerHour()
            + " KM/h");
        }

        public static void AddClimbActivity(ActivityType activityType)
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

            var sportActivity = new SportActivity(distance, date, feeling, time);

            var runAcivty = new RunActivity(distance, time, feeling, date);

            Console.WriteLine("Congradulations! You have created a new climbing activity.");

            Console.WriteLine(
            "\nDistance covered: " + distance + " kilometers" +
            "\nTimeTaken: " + time +
            "\nDate of activity: " + date +
            "\nHow You Felt After the Activity: " + afterActivityFeeling +
            "\nAverage speed: " + sportActivity.CalculateAverageSpeedInKmPerHour()
            + " KM/h");
        }

        public static void AddSwimActivity(ActivityType activityType)
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

            var sportActivity = new SportActivity(distance, date, feeling, time);

            var runAcivty = new RunActivity(distance, time, feeling, date);

            Console.WriteLine("Congradulations! You have created a new swimming activity.");

            Console.WriteLine(
            "\nDistance covered: " + distance + " kilometers" +
            "\nTimeTaken: " + time +
            "\nDate of activity: " + date +
            "\nHow You Felt After the Activity: " + afterActivityFeeling +
            "\nAverage speed: " + sportActivity.CalculateAverageSpeedInKmPerHour()
            + " KM/h");
        }
    }
}
