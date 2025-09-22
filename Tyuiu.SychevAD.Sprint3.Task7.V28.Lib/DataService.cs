using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SychevAD.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                // Проверка деления на ноль
                if (x == 0)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double numerator = Math.Cos(x) + 4 * x;
                    double denominator = 2 - Math.Sin(x) * 3 * x;

                    // Дополнительная проверка деления на ноль
                    if (Math.Abs(denominator) < 0.0001) // Проверка на близкое к нулю значение
                    {
                        valueArray[count] = 0;
                    }
                    else
                    {
                        valueArray[count] = Math.Round(numerator / denominator, 2);
                    }
                }
                count++;
            }

            return valueArray;
        }
    }
}