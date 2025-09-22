using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SychevAD.Sprint3.Task5.V29.Lib
{
    public class DataService : ISprint3Task5V29
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries += (double)x / k + Math.Sin(x);
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}