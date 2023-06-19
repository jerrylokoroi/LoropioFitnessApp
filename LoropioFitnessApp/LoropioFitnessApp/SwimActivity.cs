using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp
{
    internal class SwimActivity
    {
        public double Distance { get; set; }
        public DateTime TimeTaken { get; set; }

        public SwimActivity(double distance, DateTime timeTaken)
        {
            Distance = distance;
            TimeTaken = timeTaken;
        }
    }
}
