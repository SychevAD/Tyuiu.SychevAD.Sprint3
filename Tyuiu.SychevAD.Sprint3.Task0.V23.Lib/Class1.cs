using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SychevAD.Sprint3.Task0.V23.Lib
{
    public class DataService : ISprint3Task0V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + Math.Pow(1 / (Math.Sin(i) + 2 * Math.Pow(1.5, i)), i);
            }
            return Math.Round(sumSeries, 3);
        }
    }
}