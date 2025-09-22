using System;
using Tyuiu.SychevAD.Sprint3.Task5.V29.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task5.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Сычев А. Д. | АСОиУб 24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #29                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб 24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* y = сумма от i=1 до 3 сумма от k=1 до x (x/k + sin(x)) при X=2          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 2;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 2; // x=2, поэтому сумма от k=1 до 2

            Console.WriteLine($"Переменная X = {x}");
            Console.WriteLine($"Старт внешнего цикла i = {startValue1}");
            Console.WriteLine($"Конец внешнего цикла i = {stopValue1}");
            Console.WriteLine($"Старт внутреннего цикла k = {startValue2}");
            Console.WriteLine($"Конец внутреннего цикла k = {stopValue2}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"Сумма ряда = {result}");

            Console.ReadKey();
        }
    }
}