using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp.Activity
{
    internal interface ISportActivity
    {
        public double Distance {  get; set; }

        public TimeSpan TimeTaken { get; }

        public DateOnly Date { get;}
        
        public Feeling Feeling { get; }

        public string GetHeartRates();

        public double CalculateAverageSpeedInKmPerHour();

        public double CalculateAverageSpeedMilePerSecond();


    }
}
