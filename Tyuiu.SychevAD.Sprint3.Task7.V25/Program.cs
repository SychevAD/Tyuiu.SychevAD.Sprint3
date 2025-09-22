using System;
using Tyuiu.SychevAD.Sprint3.Task7.V25.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Сычев А. Д. | АСОиУб 24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб 24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции:           *");
            Console.WriteLine("* F(x) = (cos(x) + 4x) / (2 - sin(x) * 3x)                                *");
            Console.WriteLine("* на диапазоне [-5; 5] с шагом 1. Проверить деление на ноль.              *");
            Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine($"Старт диапазона = {startValue}");
            Console.WriteLine($"Конец диапазона = {stopValue}");
            Console.WriteLine($"Шаг = 1");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    F(x)   |");
            Console.WriteLine("+----------+-----------+");

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                Console.WriteLine("|{0,5}     | {1,8}  |", x, result[count]);
                count++;
            }

            Console.WriteLine("+----------+-----------+");

            Console.ReadKey();
        }
    }
}