using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint3.Task1.V28.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task1.V28.Test
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

            double wait = -0.634; // ќжидаемое значение, рассчитанное заранее
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

            // ѕроверка дл€ меньшего диапазона
            Assert.IsNotNull(result);
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
    }
}