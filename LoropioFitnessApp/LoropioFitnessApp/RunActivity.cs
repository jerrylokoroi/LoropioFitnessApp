using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class RunActivity
    {
        public double Distance { get; set; }
        public DateTime TimeTaken { get; set; }
        Feeling Feeling { get; set; }

        public RunActivity(double distance, DateTime timeTaken, Feeling feeling)
        {
            Distance = distance;
            TimeTaken = timeTaken;
            Feeling = feeling;
        }
    }
}

