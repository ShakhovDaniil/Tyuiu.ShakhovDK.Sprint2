﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShakhovDK.Sprint2.Task2.V19.Lib
{
    public class DataService : ISprint2Task2V19
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (((x >= 3 && x <= 10) && (y >= 5 && y <= 7)) || ((x >= 3 && x <= 5) && (y >= 3 && y <= 4)) ||
                    ((x >= 9 && x <= 12) && (y == 3)) || ((x >= 9 && x <= 10) && (y == 4)) ||
                    ((x >= 11 && x <= 13) && (y >= 6 && y <= 8)) || (x >= 11 && x <= 12) && (y >= 9 && y <= 10) ||
                    (x == 12 && y == 11) || ((x >= 9 && x <= 11) && (y <= 11 && y >= 14)) ||
                    ((x >= 12 && x <= 13) && (y == 14)) || ((x >= 7 && x <= 8) && (y == 13)) ||
                    (x == 6 && (y >= 8 && y <= 10)) || ((x >= 3 && x <= 6) && (y == 11)))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}