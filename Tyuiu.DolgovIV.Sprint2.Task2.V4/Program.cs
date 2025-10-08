using Tyuiu.DolgovIV.Sprint2.Task2.V4.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Долгов И. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                      *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Долгов Илья Витальевич | АСОиУб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры  *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в                     *");
        Console.WriteLine("* заштрихованной области.                                                 *");
        Console.WriteLine("* операций не должна нарушаться), а также арифметических выражений,       *");
        Console.WriteLine("* которая вернет логическую последовательность(массив):                   *");
        Console.WriteLine("* (True, True, True, False, True, False)                                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (ds.CheckDotInShadedArea(x, y))
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }
        else 
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }


        Console.ReadKey();
    }
}