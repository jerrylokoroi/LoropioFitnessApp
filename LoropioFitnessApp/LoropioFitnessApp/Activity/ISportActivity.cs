using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp.Activity
{
    internal interface ISportActivity
    {
        double Distance {  get; set; }

        TimeSpan TimeTaken { get; }

        DateOnly Date { get;}
        
        Feeling Feeling { get; }

        string GetHeartRates();

        double CalculateAverageSpeedInKmPerHour();

        double CalculateAverageSpeedMetersPerSecond();

        double CalculateAverageSpeed();

        string GetVelocityUnit();

        string ShowKMPerHour();

        string ShowMetersPerSecond();
        /*ReadOnlySpan<char> ToFileString();*/
    }
}
