using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint3.Task3.V26.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string value = "have a nice time";
            char item = 'e';
            int result = ds.GetCharCount(value, item);

            int wait = 2; // В строке "have a nice time" 2 буквы 'e'
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetCharCountUpperCase()
        {
            DataService ds = new DataService();

            string value = "Have A Nice Time";
            char item = 'e';
            int result = ds.GetCharCount(value, item);

            int wait = 2; // Все равно 2 буквы 'e' (регистр не учитывается)
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetCharCountNoMatches()
        {
            DataService ds = new DataService();

            string value = "have a nice time";
            char item = 'z';
            int result = ds.GetCharCount(value, item);

            int wait = 0; // Буквы 'z' нет в строке
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetCharCountEmptyString()
        {
            DataService ds = new DataService();

            string value = "";
            char item = 'e';
            int result = ds.GetCharCount(value, item);

            int wait = 0; // В пустой строке нет символов
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetCharCountMultipleOccurrences()
        {
            DataService ds = new DataService();

            string value = "eeeeee";
            char item = 'e';
            int result = ds.GetCharCount(value, item);

            int wait = 6; // 6 букв 'e'
            Assert.AreEqual(wait, result);
        }
    }
}