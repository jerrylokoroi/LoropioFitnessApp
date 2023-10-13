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
        static string directoryPath = @"C:\Data\";
        static string fileName = "activity_data.txt";

        private static readonly List<ISportActivity> _activityList = new ();

        public static void Add(ISportActivity sportActivity)
        {
            try
            {

                if (sportActivity == null)
                {
                    throw new ArgumentNullException(nameof(sportActivity), "Sport activity cannot be null.");
                }

                _activityList.Add(sportActivity);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error while adding activity: {ex.Message}");
                Console.ResetColor();
            }

        }

        internal static void SaveActivities()
        {
            
            string path = $"{directoryPath}{fileName}";
            StringBuilder sb = new StringBuilder();

            try
            {
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
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error while saving activities: {ex.Message}");
                Console.ResetColor();
            }
            
        }
        
        public static List<ISportActivity> GetAll()
        {
            
            if (_activityList.Any())
                return _activityList;
            return LoadActivities();
        }

        internal static List<ISportActivity> LoadActivities()
        {

            try
            {
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
                        _activityList.Add(sportActivity);
                    }
                }
                else
                {
                    Console.WriteLine("No activity data found.");
                }
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error while parsing activity data: {ex.Message}");
                Console.ResetColor();
            }
            catch (IOException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error while reading activity data: {ex.Message}");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
            }

            return _activityList;
        }


    }
}
