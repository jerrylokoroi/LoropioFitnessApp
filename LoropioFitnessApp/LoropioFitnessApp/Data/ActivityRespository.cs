using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp.Data
{
    internal class ActivityRespository
    {

        private static readonly List<RunActivity> _activityList = new List<RunActivity>();

        public static void Add(RunActivity activity)
        {
            _activityList.Add(activity);
        }

        public static List<RunActivity> GetAll()
        {
            return _activityList;
        }
    }
}
