using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint3.Task2.V18.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 18;
            double result = ds.GetSumSeries(a, startValue, stopValue);

            double wait = -0.634; // Ожидаемое значение
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumSeriesDifferentRange()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 5;
            double result = ds.GetSumSeries(a, startValue, stopValue);

            // Ручной расчет для k=1 до 5
            double manualSum = 0;
            for (int k = 1; k <= 5; k++)
            {
                manualSum += (Math.Pow(0.5, k) + 0.25) * Math.Cos(k);
            }
            manualSum = Math.Round(manualSum, 3);

            Assert.AreEqual(manualSum, result);
        }

        [TestMethod]
        public void ValidGetSumSeriesSingleTerm()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 1;
            double result = ds.GetSumSeries(a, startValue, stopValue);

            double term = (Math.Pow(a, 1) + 0.25) * Math.Cos(1);
            double wait = Math.Round(term, 3);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumSeriesEmptyRange()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 10;
            int stopValue = 5; // Некорректный диапазон
            double result = ds.GetSumSeries(a, startValue, stopValue);

            Assert.AreEqual(0, result);
        }
    }
}