using Tyuiu.ShakhovDK.Sprint2.Task0.V16.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 1025;

        int y = 275;

        bool[] res = new bool[6];

        res = ds.GetCompareOperations(x, y);

        Console.Title = "Спринт #1 | Выполнил: Шахов Д.К | ИИПБ-24-2";
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* Спринт #2                                                                              *");
        Console.WriteLine("* Тема: Операции сравнения                                                               *");
        Console.WriteLine("* Задание #0                                                                             *");
        Console.WriteLine("* Вариант #16                                                                            *");
        Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                               *");
        Console.WriteLine("* Написать программу из операций сравнений                                               *");
        Console.WriteLine("* (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)               *");
        Console.WriteLine("* и арифметических выражений,                                                            *");
        Console.WriteLine("* которая вернет логическую последовательность(массив):                                  *");
        Console.WriteLine("* (True, False, True, False, True, False),                                               *");
        Console.WriteLine("* при x = 1025, y = 275                                                                  *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* X = 1025                                                                               *");
        Console.WriteLine("* Y = 275                                                                                *");
        Console.WriteLine("******************************************************************************************");


        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("*****************************************************************************************");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}