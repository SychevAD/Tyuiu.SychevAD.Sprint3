using System;
using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SychevAD.Sprint3.Task1.V28.Lib
{
    public class DataService : ISprint3Task1V28
    {
        public double GetSumSeries(double a, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int k = startValue;

            while (k <= stopValue)
            {
                double term = (Math.Pow(a, k) + 0.25) * Math.Cos(k);
                sumSeries += term;
                k++;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}