using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SychevAD.Sprint3.Task6.V2.Lib
{
    public class DataService : ISprint3Task6V2
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalDivisors = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                for (int divisor = 1; divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        totalDivisors++;
                    }
                }
            }

            return totalDivisors;
        }
    }
}