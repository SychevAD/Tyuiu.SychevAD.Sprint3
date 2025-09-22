using System;
using Tyuiu.SychevAD.Sprint3.Task3.V26.Lib;

namespace Tyuiu.SychevAD.Sprint3.Task3.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Сычев А. Д. | АСОиУб 24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Сычев Александр Дмитриевич | АСОиУб 24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать количество букв 'e' в строке:         *");
            Console.WriteLine("* 'have a nice time'                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "have a nice time";
            char item = 'e';

            Console.WriteLine($"Строка: '{value}'");
            Console.WriteLine($"Искомый символ: '{item}'");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int result = ds.GetCharCount(value, item);
            Console.WriteLine($"Количество символов '{item}' в строке = {result}");

            Console.ReadKey();
        }
    }
}