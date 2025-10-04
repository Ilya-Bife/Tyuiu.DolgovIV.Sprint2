using System.Data.Common;
using Tyuiu.DolgovIV.Sprint2.Task0.V24.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Долгов И. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #24                                                             *");
        Console.WriteLine("* Выполнил: Долгов Илья Витальевич | АСОиУб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений                                *");
        Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)*");
        Console.WriteLine("* и арифметических выражений, которая вернет логическую                   *");
        Console.WriteLine("* последовательность(массив): (True, True, False, False, True, True)      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 135;
        int y = 755;

        Console.WriteLine("Значение X = 135");

        Console.WriteLine("Значение Y = 755");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(ds.GetCompareOperations(x, y)[i]);
        }

        Console.ReadKey();

    }
}