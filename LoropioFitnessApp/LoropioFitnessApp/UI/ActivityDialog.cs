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

            string[] validActivityTypeInput = new string[4] { "1", "2", "3", "4" };

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
            try
            {
                Console.WriteLine("Enter the total distance covered on the activity in KM");
                string validActivityTypeInput = Console.ReadLine();
                double distance = double.Parse(validActivityTypeInput);

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

                var runActivity = new RunActivity(distance * 1000, time, feeling, date);

                ActivityRespository.Add(runActivity);

                ActivityRespository.SaveActivities();

                Console.WriteLine("New run Activity created and saved.");
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
                Console.ResetColor();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }

        }

        private static void AddBikeActivity(ActivityType activityType)
        {
            try
            {
                Console.WriteLine("Enter the total distance covered on the activity in KM");
                string validActivityTypeInput = Console.ReadLine();
                double distance = double.Parse(validActivityTypeInput);

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

                ActivityRespository.SaveActivities();
                Console.WriteLine("New bike Activity created and saved.");
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
                Console.ResetColor();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }

        }

        public static void AddClimbActivity(ActivityType activityType)
        {
            try
            {
                Console.WriteLine("Enter the total distance covered on the activity in Meters");
                string validActivityTypeInput = Console.ReadLine();
                double distance = double.Parse(validActivityTypeInput);

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

                var climbActivity = new ClimbActivity(distance, time, feeling, date);

                ActivityRespository.Add(climbActivity);

                ActivityRespository.SaveActivities();

                Console.WriteLine("New climb Activity created and saved.");
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
                Console.ResetColor();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }

        }

        private static void AddSwimActivity(ActivityType activityType)
        {
            try
            {
                Console.WriteLine("Enter the total distance covered on the activity in Meters");
                string validActivityTypeInput = Console.ReadLine();
                double distance = double.Parse(validActivityTypeInput);

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

                var swimActivity = new SwimActivity(distance, time, feeling, date);

                ActivityRespository.Add(swimActivity);

                ActivityRespository.SaveActivities();

                Console.WriteLine("New swim Activity created and saved.");
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}. Please enter a valid number.");
                Console.ResetColor();
            }
            catch (ArgumentNullException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }

        }

        public static void DisplayAllActivities()
        {
            Console.WriteLine("********************");
            Console.WriteLine("* Your Activities  *");
            Console.WriteLine("********************");

            var allActivities = ActivityRespository.GetAll();
            DisplayActivities(allActivities);

            Console.WriteLine("Press ENTER to continue \n");
            if (Console.ReadKey().Key == ConsoleKey.Enter) 
              Console.Clear();
        }

        public static void DisplayActivities(List<ISportActivity> activities)
        {
           foreach (var activity in activities)
           {
               Console.WriteLine($"Activity Name:{activity.GetType().Name};");
               Console.WriteLine($"Distance:{activity.Distance};");
               Console.WriteLine($"TimeTaken:{activity.TimeTaken};");
               Console.WriteLine($"Average Speed:{activity.CalculateAverageSpeed() + " " + activity.GetVelocityUnit()};");
               Console.WriteLine($"Feeling:{activity.Feeling};");
               Console.WriteLine($"Date:{activity.Date};");
               Console.WriteLine($"HeartRate:{activity.GetHeartRates()};");
           }
        }

        public static void LoadActivity()
        {
            var allActivities = ActivityRespository.GetAll();

        }

        public static void LoadRunActivity()
        {
            var allActivities = ActivityRespository.GetAll().OfType<RunActivity>();

            if (allActivities.Any())
            {
                Console.WriteLine("********************");
                Console.WriteLine("* Run Activities   *");
                Console.WriteLine("********************");

                foreach (var activity in allActivities)
                {
                    Console.WriteLine($"Distance: {activity.Distance} {activity.DistanceUnit};");
                    Console.WriteLine($"Time Taken: {activity.TimeTaken};");
                    Console.WriteLine($"Feeling: {activity.Feeling};");
                    Console.WriteLine($"Date: {activity.Date};");
                    Console.WriteLine($"Average Speed: {activity.CalculateAverageSpeed()} {activity.GetVelocityUnit()};");
                    Console.WriteLine($"Heart Rate: {activity.GetHeartRates()};");
                }
            }
            else
            {
                Console.WriteLine("No Run Activities found.");
            }
        }

        public static void LoadBikeActivity()
        {
            var allActivities = ActivityRespository.GetAll().OfType<BikeActivity>();

            if (allActivities.Any())
            {
                Console.WriteLine("********************");
                Console.WriteLine("* Bike Activities  *");
                Console.WriteLine("********************");

                foreach (var activity in allActivities)
                {
                    Console.WriteLine($"Distance: {activity.Distance} {activity.DistanceUnit};");
                    Console.WriteLine($"Time Taken: {activity.TimeTaken};");
                    Console.WriteLine($"Feeling: {activity.Feeling};");
                    Console.WriteLine($"Date: {activity.Date};");
                    Console.WriteLine($"Average Speed: {activity.CalculateAverageSpeed()} {activity.GetVelocityUnit()};");
                    Console.WriteLine($"Heart Rate: {activity.GetHeartRates()};");
                }
            }
            else
            {
                Console.WriteLine("No Bike Activities found.");
            }
        }

        public static void LoadClimbActivity()
        {
            var allActivities = ActivityRespository.GetAll().OfType<ClimbActivity>();

            if (allActivities.Any())
            {
                Console.WriteLine("********************");
                Console.WriteLine("* Climb Activities *");
                Console.WriteLine("********************");

                foreach (var activity in allActivities)
                {
                    Console.WriteLine($"Distance: {activity.Distance} {activity.DistanceUnit};");
                    Console.WriteLine($"Time Taken: {activity.TimeTaken};");
                    Console.WriteLine($"Feeling: {activity.Feeling};");
                    Console.WriteLine($"Date: {activity.Date};");
                    Console.WriteLine($"Average Speed: {activity.CalculateAverageSpeed()} {activity.GetVelocityUnit()};");
                    Console.WriteLine($"Heart Rate: {activity.GetHeartRates()};");
                }
            }
            else
            {
                Console.WriteLine("No Climb Activities found.");
            }
        }

        public static void LoadSwimActivity()
        {
            var allActivities = ActivityRespository.GetAll().OfType<SwimActivity>();

            if (allActivities.Any())
            {
                Console.WriteLine("********************");
                Console.WriteLine("* Swim Activities  *");
                Console.WriteLine("********************");

                foreach (var activity in allActivities)
                {
                    Console.WriteLine($"Distance: {activity.Distance} {activity.DistanceUnit};");
                    Console.WriteLine($"Time Taken: {activity.TimeTaken};");
                    Console.WriteLine($"Feeling: {activity.Feeling};");
                    Console.WriteLine($"Date: {activity.Date};");
                    Console.WriteLine($"Average Speed: {activity.CalculateAverageSpeed()} {activity.GetVelocityUnit()};");
                    Console.WriteLine($"Heart Rate: {activity.GetHeartRates()};");
                }
            }
            else
            {
                Console.WriteLine("No Swim Activities found.");
            }
        }

        internal static void LoadActivityByDate()
        {
            try
            {
                Console.WriteLine("Enter the date of the activity you would like to load (use the format YYYY/MM/DD)");
                string dateOfActivity = Console.ReadLine();
                if (DateOnly.TryParse(dateOfActivity, out DateOnly date))
                {
                    var allActivities = ActivityRespository.LoadActivities();

                    var activitiesOnDate = allActivities.Where(activity => activity.Date == date);

                    if (activitiesOnDate.Any())
                    {
                        Console.WriteLine($"Activities on {date}:");
                        foreach (var activity in activitiesOnDate)
                        {
                            Console.WriteLine($"Activity Name:{activity.GetType().Name};");
                            Console.WriteLine($"Distance:{activity.Distance};");
                            Console.WriteLine($"TimeTaken:{activity.TimeTaken};");
                            Console.WriteLine($"Average Speed:{activity.CalculateAverageSpeed() + " " + activity.GetVelocityUnit()};");
                            Console.WriteLine($"Feeling:{activity.Feeling};");
                            Console.WriteLine($"Date:{activity.Date};");
                            Console.WriteLine($"HeartRate:{activity.GetHeartRates()};");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"No activities found on {date}.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please use the format YYYY/MM/DD.");
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }
        }

    }
}
