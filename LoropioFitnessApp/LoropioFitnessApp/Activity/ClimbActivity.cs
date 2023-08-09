using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class ClimbActivity
    {
        public double Distance { get; set; }
        public TimeSpan TimeTaken { get; set; }
        Feeling Feeling { get; set; }

        public DateOnly Date { get; set; }

        public ClimbActivity(double distance, TimeSpan timeTaken, Feeling feeling, DateOnly date)
        {
            Distance = distance;
            TimeTaken = timeTaken;
            Feeling = feeling;
            Date = date;
        }
    }
}
