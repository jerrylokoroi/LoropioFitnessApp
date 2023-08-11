using LoropioFitnessApp.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp.Data
{
    internal class ActivityRespository
    {

        private static readonly List<ISportActivity> _activityList = new ();

        public static void Add(ISportActivity sportActivity)
        {
            _activityList.Add(sportActivity);
        }

        public static List<ISportActivity> GetAll()
        {
            return _activityList;
        }
    }
}
