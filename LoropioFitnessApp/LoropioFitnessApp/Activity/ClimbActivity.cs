using LoropioFitnessApp.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class ClimbActivity : SportActivity
    {
        public override double CalculateAverageSpeed()
        {
            return CalculateAverageSpeedMetersPerSecond();
        }

        public override string DistanceUnit => "M";

        public override string GetVelocityUnit()
        {
            return ShowMetersPerSecond();
        }
        public ClimbActivity(double distance, TimeSpan timeTaken, Feeling feeling, DateOnly date) : base(distance, date, feeling, timeTaken)
        {
            Distance = distance;
            TimeTaken = timeTaken;
            Feeling = feeling;
            Date = date;
        }

        public override ReadOnlySpan<char> ToFileString()
        {
            return $"{GetType().Name}|{Distance}|{TimeTaken}|{Feeling}|{Date}".AsSpan();
        }
    }
}
