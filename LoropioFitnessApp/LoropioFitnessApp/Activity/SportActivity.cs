using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp.Activity
{
    public class SportActivity : ISportActivity
    {
        private double _distance;
        public virtual double Distance 
        {
            get { return _distance; }
            set { _distance = value; }
        }

        private TimeSpan _timeSpan;
        public TimeSpan TimeTaken 
        {
            get { return _timeSpan; }
            set { _timeSpan = value; }
        }

        private DateOnly _date;
        public DateOnly Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private Feeling _feeling;


        public Feeling Feeling
        {
            get { return _feeling; }
            set { _feeling = value; }
        }

        public SportActivity(double distance, DateOnly date, Feeling feeling, TimeSpan time)
        {
            Distance = distance;
            Date = date;
            Feeling = feeling;
            TimeTaken = time;
        }

        public string GetHeartRates()
        {
            int[] simulatedHeartRates = HeartRateSensorData.SimulateHeartRates(Feeling);
            return string.Join(" ", simulatedHeartRates);
        }

        public double CalculateAverageSpeedInKmPerHour()
        {
            var averageSpeedInKmPerHours = (Distance / 1000) / (TimeTaken.Hours + (TimeTaken.Minutes / 60) + (TimeTaken.Seconds / 3600));
            return Math.Round(averageSpeedInKmPerHours, 2);
        }

        public double CalculateAverageSpeedMetersPerSecond()
        {
            var averageSpeedInMetersPerSecond = Distance / (TimeTaken.Hours * 3600 + TimeTaken.Minutes * 60 + TimeTaken.Seconds);
            return Math.Round(averageSpeedInMetersPerSecond, 2);
        }
      
        public virtual double CalculateAverageSpeed()
        {
            return CalculateAverageSpeedInKmPerHour();
        }

        public virtual string DistanceUnit => "";

        public virtual string GetVelocityUnit()
        {
            return ShowKMPerHour();
        }
          
        public string ShowKMPerHour()
        {
            return "Km/H";
        }

        public string ShowMetersPerSecond()
        {
            return "m/s";
        }

        public virtual double GetActivityDistance()
        {
            return _distance;
        }

        public override string ToString()
        {
            return $"{GetType().Name}|{Distance}|{TimeTaken}|{Feeling}|{Date}";
        }

        public virtual ReadOnlySpan<char> ToFileString()
        {
            return ToString().AsSpan();
        }
    }
}
