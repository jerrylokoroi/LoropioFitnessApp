using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoropioFitnessApp.Activity
{
    internal class HeartRateSensorData
    {

        public static int[] SimulateHeartRates(Feeling feeling)
        {
            int baseHeartRateBad = 160;
            int baseHeartRateOk = 150;
            int baseHeartRateGood = 140;
            int baseHeartRateStrong = 130;
            int baseHeartRateVeryStrong = 120;

            int[] result;

            switch (feeling)
            {
                case Feeling.Bad:
                    result = GenerateRandomInts(baseHeartRateBad);
                    break;
                case Feeling.Ok:
                    result = GenerateRandomInts(baseHeartRateOk);
                    break;
                case Feeling.Good:
                    result = GenerateRandomInts(baseHeartRateGood);
                    break;
                case Feeling.Strong:
                    result = GenerateRandomInts(baseHeartRateStrong);
                    break;
                case Feeling.VeryStrong:
                    result = GenerateRandomInts(baseHeartRateVeryStrong);
                    break;
                default:
                    result = new int[10];
                    break;
            }
            return result;
        }

        private static int[] GenerateRandomInts(int baseHeartRate)
        {
            Random random = new Random();
            int[] heartRates = new int[10];

            for (int i = 0; i < heartRates.Length; i++)
            {
                heartRates[i] = baseHeartRate + random.Next(0, 20);
            }

            return heartRates;
        }
    }
}

