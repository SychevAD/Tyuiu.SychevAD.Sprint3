using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint3.Task5.V29.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task5.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 2;
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            // Ручной расчет:
            // i=1: k=1: 2/1 + sin(2) = 2 + 0.909 = 2.909
            //        k=2: 2/2 + sin(2) = 1 + 0.909 = 1.909
            // i=2: k=1: 2/1 + sin(2) = 2 + 0.909 = 2.909
            //        k=2: 2/2 + sin(2) = 1 + 0.909 = 1.909
            // i=3: k=1: 2/1 + sin(2) = 2 + 0.909 = 2.909
            //        k=2: 2/2 + sin(2) = 1 + 0.909 = 1.909
            // Сумма = (2.909 + 1.909) * 3 = 4.818 * 3 = 14.454
            double wait = 14.454;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesDifferentX()
        {
            DataService ds = new DataService();

            int x = 3;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 2;
            int stopValue2 = 3;
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesSingleIteration()
        {
            DataService ds = new DataService();

            int x = 1;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 1;
            int stopValue2 = 1;
            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 1.0 / 1 + Math.Sin(1);
            wait = Math.Round(wait, 3);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumSumSeriesZeroK()
        {
            DataService ds = new DataService();

            int x = 2;
            int startValue1 = 1;
            int startValue2 = 0; // k=0 (деление на 0!)
            int stopValue1 = 1;
            int stopValue2 = 2;

            // Ожидаем исключение при делении на ноль
            Assert.ThrowsException<DivideByZeroException>(() =>
                ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2));
        }
    }
}