﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class SportActivity
    {

        public static double CalculateAverageSpeedInKmPerHour(double distance, TimeOnly time);
        public double Distance { get; set; }
        public DateTime TimeTaken { get; set; }

        Feeling Feeling { get; set; }

        public SportActivity(double distance, DateTime timeTaken, Feeling feeling)
        {

        }

        public static double CalculateAverageSpeedInKmPerHour(double distance, TimeOnly time, Feeling feeling)
        {
            
            double totalSeconds = time.Hour * 3600 + time.Minute * 60 + time.Second;
            double totalHours = totalSeconds / 3600;
            double averageSpeed = (distance / totalHours);
            return Math.Round(averageSpeed, 2);
        }

        public static double CalculateAverageSpeedMilePerSecond(double distance, TimeOnly time, Feeling feeling)
        {
            double totalSeconds = time.Hour * 3600 + time.Minute * 60 + time.Second;
            double distanceInMiles = distance / 1.60934; //Converting KM to Miles
            double averageSpeed = distanceInMiles / totalSeconds;
            return Math.Round(averageSpeed, 2);
        }
    }
}
