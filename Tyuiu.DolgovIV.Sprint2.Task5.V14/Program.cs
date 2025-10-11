using Tyuiu.DolgovIV.Sprint2.Task5.V14.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Долгов И. В. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Долгов Илья Витальевич | АСОиУб-25-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано целое число k (1 <= k <= 365). Определить, каким днем недели       *");
        Console.WriteLine("* (понедельником, вторником, …, субботой или воскресеньем) является k-й   *");
        Console.WriteLine("* день не високосного года, в котором 1 января d-й день недели            *");
        Console.WriteLine("* (если 1 января — понедельник, то d = 1 , если вторник — d = 2 , …,      *");
        Console.WriteLine("*  если воскресенье — d = 7).                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int k = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.FindDayName(k, d));

        Console.ReadKey();
    }
}