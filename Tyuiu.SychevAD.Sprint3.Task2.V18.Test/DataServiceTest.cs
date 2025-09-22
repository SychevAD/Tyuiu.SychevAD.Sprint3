using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint3.Task2.V18.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 18;
            double result = ds.GetMultiplySeries(a, startValue, stopValue);

            double wait = 0.001; // Ожидаемое значение для произведения
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesDifferentRange()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 5;
            double result = ds.GetMultiplySeries(a, startValue, stopValue);

            // Ручной расчет для k=1 до 5
            double manualProduct = 1;
            for (int k = 1; k <= 5; k++)
            {
                manualProduct *= (Math.Pow(0.5, k) + 0.25) * Math.Cos(k);
            }
            manualProduct = Math.Round(manualProduct, 3);

            Assert.AreEqual(manualProduct, result);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesSingleTerm()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 1;
            int stopValue = 1;
            double result = ds.GetMultiplySeries(a, startValue, stopValue);

            double term = (Math.Pow(a, 1) + 0.25) * Math.Cos(1);
            double wait = Math.Round(term, 3);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetMultiplySeriesEmptyRange()
        {
            DataService ds = new DataService();

            double a = 0.5;
            int startValue = 10;
            int stopValue = 5; // Некорректный диапазон
            double result = ds.GetMultiplySeries(a, startValue, stopValue);

            Assert.AreEqual(1, result); // Произведение пустого множества = 1
        }
    }
}