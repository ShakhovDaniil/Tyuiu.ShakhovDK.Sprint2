﻿using Tyuiu.ShakhovDK.Sprint2.Task6.V11.Lib;
DataService ds = new DataService();
int g, m, n;
string res;
Console.Title = "Спринт #2 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #2                                                                              *");
Console.WriteLine("* Тема: Получение результата из switch                                                   *");
Console.WriteLine("* Задание #6                                                                             *");
Console.WriteLine("* Вариант #11                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:\n" +
"g (год), m (порядковый номер месяца) и n (число).\n" +
"По заданным g, n и m определить дату следующего дня. Заданный год не является високосным*");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Введите год:                                                                           *");
g = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* Введите месяц:                                                                         *");
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* Введите число:                                                                         *");
n = Convert.ToInt32(Console.ReadLine());
res = ds.FindDateOfNextDay(g, m, n);
Console.WriteLine("******************************************************************************************");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine($"Дата следующего дня = {res}");
Console.WriteLine("******************************************************************************************");
Console.ReadKey();