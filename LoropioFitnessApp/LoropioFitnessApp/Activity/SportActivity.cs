using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class SportActivity
    {
        public double Distance { get; set; }
        public DateOnly ActivityDate { get; set; }
        Feeling Feeling { get; set; }

        TimeSpan TimeTaken { get; set; }

        public SportActivity(double distance, DateOnly activityDate, Feeling feeling, TimeSpan time)
        {
            Distance = distance;
            ActivityDate = activityDate;
            Feeling = feeling;
            TimeTaken = time;
        }

        public double CalculateAverageSpeedInKmPerHour()
        {
            var averageSpeedInKmPerHour = (Distance / 1000) / (TimeTaken.Hours + (TimeTaken.Minutes / 60f) + (TimeTaken.Seconds / 3600f));
            return Math.Round(averageSpeedInKmPerHour, 2);
        }

        public double CalculateAverageSpeedMilePerSecond(double distance, TimeOnly time, Feeling feeling)
        {
            var averageSpeedInMilePerSecond = Distance / (TimeTaken.Hours * 3600) + (TimeTaken.Minutes * 60f) + (TimeTaken.Seconds);
            return Math.Round(averageSpeedInMilePerSecond, 2);
        }
    }
}
