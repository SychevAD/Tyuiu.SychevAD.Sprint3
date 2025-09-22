using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SychevAD.Sprint3.Task2.V18.Lib
{
    public class DataService : ISprint3Task2V18
    {
        public double GetMultiplySeries(double a, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                double term = (Math.Pow(a, k) + 0.25) * Math.Cos(k);
                multiplySeries *= term;
                k++;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}