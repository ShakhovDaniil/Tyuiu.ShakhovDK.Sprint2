﻿using Tyuiu.ShakhovDK.Sprint2.Task2.V19.Lib;

DataService ds = new DataService();
Console.Title = "Спринт #2 | Выполнил: Шахов Д.К | ИИПБ-24-2";
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Спринт #2                                                                              *");
Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                                     *");
Console.WriteLine("* Задание #2                                                                             *");
Console.WriteLine("* Вариант #19                                                                            *");
Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры и " +
    "вычисляет находится ли точка с координатами X,Y в заштрихованной области.                              *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* Введите значение переменной x:                                                         *");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("* Введите значение переменной y:                                                         *");
int y = Convert.ToInt32(Console.ReadLine());
var res = ds.CheckDotInShadedArea(x, y);
Console.WriteLine("******************************************************************************************");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
if (res)
{
    Console.WriteLine("Точка находиться в заштрихованной области");
}
else
{
    Console.WriteLine("Точка не находиться в заштрихованной области");
}
Console.WriteLine("******************************************************************************************");