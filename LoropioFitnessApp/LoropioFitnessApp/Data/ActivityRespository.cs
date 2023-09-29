using LoropioFitnessApp.Activity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp.Data
{
    internal class ActivityRespository
    {
        private static readonly List<ISportActivity> _activityList = new ();

        public static void Add(ISportActivity sportActivity)
        {
            _activityList.Add(sportActivity);
        }

        internal static void SaveActivities(List<ISportActivity> activities)
        {
            string directoryPath = @"C:\Data\";
            string fileName = "activity_data.txt";
            string path = $"{directoryPath}{fileName}";
            StringBuilder sb = new StringBuilder();
            foreach (var sportActivity in _activityList)
            {
                sb.Append($"ActivityName:{sportActivity.GetType().Name};");
                sb.Append($"Distance:{sportActivity.Distance};");
                sb.Append($"TimeTaken:{sportActivity.TimeTaken};");
                sb.Append($"AverageSpeed:{sportActivity.CalculateAverageSpeed()};");
                sb.Append($"AverageSpeedUnit:{sportActivity.GetVelocityUnit()};");
                sb.Append($"Feeling:{sportActivity.Feeling};");
                sb.Append($"HeartRate:{sportActivity.GetHeartRates()};");
                sb.Append($"Date:{sportActivity.Date};");
                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved activity successfully");
            Console.ResetColor();

        }
        public static List<ISportActivity> GetAll()
        {
            
            return _activityList;
        }

        internal static List<ISportActivity> LoadActivities()
        {
            List<ISportActivity> loadedActivities = new List<ISportActivity>();
            string directoryPath = @"C:\Data\";
            string fileName = "activity_data.txt";
            string path = Path.Combine(directoryPath, fileName);

            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);

                _activityList.Clear();

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');

                    string activityName = parts[0].Split(':')[1]; 
                    double distance = double.Parse(parts[1].Split(':')[1]); 
                    TimeSpan timeTaken = TimeSpan.Parse(parts[2].Split(':')[1]); 
                    double averageSpeed = double.Parse(parts[3].Split(':')[1]); 
                    string averageSpeedUnit = parts[4].Split(':')[1]; 
                    Feeling feeling = (Feeling)Enum.Parse(typeof(Feeling), parts[5].Split(':')[1]); 
                    string heartRate = parts[6].Split(':')[1]; 
                    DateOnly date = DateOnly.Parse(parts[7].Split(':')[1]); 

                    ISportActivity sportActivity;
                    switch (activityName)
                    {
                        case "RunActivity":
                            sportActivity = new RunActivity(distance, timeTaken, feeling, date);
                            break;
                        case "BikeActivity":
                            sportActivity = new BikeActivity(distance, date, feeling, timeTaken);
                            break;
                        case "ClimbActivity":
                            sportActivity = new ClimbActivity(distance, timeTaken, feeling, date);
                            break;
                        case "SwimActivity":
                            sportActivity = new SwimActivity(distance, timeTaken, feeling, date);
                            break;
                        default:
                            
                            continue; 
                    }
                   
                    loadedActivities.Add(sportActivity);
                }
            }
            else
            {
                Console.WriteLine("No activity data found.");
            }

            return loadedActivities;
        }


    }
}
