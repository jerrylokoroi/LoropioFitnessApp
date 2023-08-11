using LoropioFitnessApp.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class RunActivity : SportActivity
    {

        public RunActivity(double distance, TimeSpan timeTaken, Feeling feeling, DateOnly date) : base(distance, date, feeling, timeTaken)
        {
            Distance = distance;
            TimeTaken = timeTaken;
            Feeling = feeling;
            Date = date;
        }
    }
}

