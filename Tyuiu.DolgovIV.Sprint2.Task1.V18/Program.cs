using System.Data;
using Tyuiu.DolgovIV.Sprint2.Task1.V18.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Долгов И. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #18                                                             *");
        Console.WriteLine("* Выполнил: Долгов Илья Витальевич | АСОиУб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность можно чередовать, но использовать один раз в         *");
        Console.WriteLine("* выражении) и логических операций (|, &, ||, &&, !, ^, последовательность*");
        Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
        Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
        Console.WriteLine("* (True, True, True, False, True, False)                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int a = 155;
        int b = 696;
        int c = 242;
        int d = 541;

        Console.WriteLine("Значение A = 155");
        Console.WriteLine("Значение B = 696");
        Console.WriteLine("Значение C = 242");
        Console.WriteLine("Значение D = 541");

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(ds.GetLogicOperations(a,b,c,d)[i]);
        }

        Console.ReadKey();
    }
}