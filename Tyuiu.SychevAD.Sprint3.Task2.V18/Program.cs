using System;
using Tyuiu.SychevAD.Sprint3.Task2.V18.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task2.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Сычев А. Д. | АСОиУб 24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла while                                              *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб 24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет произведение *");
            Console.WriteLine("* ряда по формуле, при a=0,5:                                             *");
            Console.WriteLine("* P = произведение от k=1 до 18 (a^k + 0,25) * cos(k)                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value = 5; // 5 соответствует a=0.5
            int startValue = 1;
            int stopValue = 18;

            Console.WriteLine($"Значение value = {value} (a = 0.5)");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine($"Произведение ряда = {result}");

            Console.ReadKey();
        }
    }
}