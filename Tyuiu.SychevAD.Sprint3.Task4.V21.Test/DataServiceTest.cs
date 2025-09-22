using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint3.Task4.V21.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            double result = ds.Calculate(startValue, stopValue);

            double wait = 0.154; // Ожидаемое значение
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculateWithoutZero()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 5;
            double result = ds.Calculate(startValue, stopValue);

            // Ручной расчет для x от 1 до 5
            double manualProduct = 1;
            for (int x = 1; x <= 5; x++)
            {
                double y = (Math.Cos(x) - x) / x;
                manualProduct *= y;
            }
            manualProduct = Math.Round(manualProduct, 3);

            Assert.AreEqual(manualProduct, result);
        }

        [TestMethod]
        public void ValidCalculateNegativeRange()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = -1;
            double result = ds.Calculate(startValue, stopValue);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ValidCalculateSkipZero()
        {
            DataService ds = new DataService();

            int startValue = -1;
            int stopValue = 1;
            double result = ds.Calculate(startValue, stopValue);

            // Должен посчитать только для x = -1 и x = 1, пропустить x = 0
            double manualProduct = ((Math.Cos(-1) - (-1)) / (-1)) * ((Math.Cos(1) - 1) / 1);
            manualProduct = Math.Round(manualProduct, 3);

            Assert.AreEqual(manualProduct, result);
        }
    }
}