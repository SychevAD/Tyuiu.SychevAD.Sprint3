using System;
using Tyuiu.SychevAD.Sprint3.Task1.V28.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task1.V28
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
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб 24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл while, которая вычисляет сумму ряда   *");
            Console.WriteLine("* по формуле, при a=0,5:                                                  *");
            Console.WriteLine("* S = сумма от k=1 до 18 (a^k + 0,25) * cos(k)                            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double a = 0.5;
            int startValue = 1;
            int stopValue = 18;

            Console.WriteLine($"Переменная a = {a}");
            Console.WriteLine($"Старт шага = {startValue}");
            Console.WriteLine($"Конец шага = {stopValue}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSeries(a, startValue, stopValue);
            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}