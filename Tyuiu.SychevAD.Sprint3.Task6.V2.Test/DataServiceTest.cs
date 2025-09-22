using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.SychevAD.Sprint3.Task6.V2.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 12;
            int stopValue = 18;
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // ������ ������:
            // 12: 1,2,3,4,6,12 = 6 ���������
            // 13: 1,13 = 2 ��������
            // 14: 1,2,7,14 = 4 ��������
            // 15: 1,3,5,15 = 4 ��������
            // 16: 1,2,4,8,16 = 5 ���������
            // 17: 1,17 = 2 ��������
            // 18: 1,2,3,6,9,18 = 6 ���������
            // �����: 6 + 2 + 4 + 4 + 5 + 2 + 6 = 29
            int wait = 29;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsSingleNumber()
        {
            DataService ds = new DataService();

            int startValue = 12;
            int stopValue = 12;
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 6; // � ����� 12 - 6 ���������
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsSmallRange()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 3;
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // 1: 1 ��������, 2: 2 ��������, 3: 2 ��������
            int wait = 5;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsPrimeNumbers()
        {
            DataService ds = new DataService();

            int startValue = 13;
            int stopValue = 17;
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // 13: 2 ��������, 14: 4 ��������, 15: 4 ��������, 16: 5 ���������, 17: 2 ��������
            int wait = 17;
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidGetSumTheDivisorsReverseRange()
        {
            DataService ds = new DataService();

            int startValue = 18;
            int stopValue = 12; // ������������ ��������
            int result = ds.GetSumTheDivisors(startValue, stopValue);

            // ������ ������� 0, ��� ��� startValue > stopValue
            int wait = 0;
            Assert.AreEqual(wait, result);
        }
    }
}