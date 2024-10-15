﻿using Tyuiu.ShakhovDK.Sprint2.Task1.V24.Lib;

DataService ds = new DataService();
int a = 325, b = 325, c = 242, d = 324;
bool[] res = new bool[6];
res = ds.GetLogicOperations(a, b, c, d);

Console.Title = "Спринт #2 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #2                                                                              *");
Console.WriteLine("* Тема: Логические операции                                                              *");
Console.WriteLine("* Задание #1                                                                             *");
Console.WriteLine("* Вариант #24                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("* Написать программу из операций сравнений                                               *");
Console.WriteLine("* (==, !=, <, >, <=, >=,                                                                 *");
Console.WriteLine("* последовательность можно чередовать, но использовать один раз в выражении)             *");
Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^,                                             *");
Console.WriteLine("* последовательность операций не должна нарушаться),                                     *");
Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность(массив):*");
Console.WriteLine("* (True, False, True, False, True, False),                                               *");
Console.WriteLine("* при a = 325, b = 325, c = 242, d = 324                                                 *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine($"* a = {a}                                                                               *");
Console.WriteLine($"* b = {b}                                                                               *");
Console.WriteLine($"* c = {c}                                                                               *");
Console.WriteLine($"* d = {d}                                                                               *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine("******************************************************************************************");

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(res[i]);
}

Console.ReadKey();