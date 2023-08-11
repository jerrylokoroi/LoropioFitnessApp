using LoropioFitnessApp.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    public class BikeActivity : SportActivity
    {
        public BikeActivity(double distance, DateOnly date, Feeling feeling, TimeSpan timeTaken) : base(distance, date, feeling, timeTaken)
        {
            Distance = distance;
            TimeTaken = timeTaken;
            Feeling = feeling;
            Date = date;
        }
    }
}
