using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShakhovDK.Sprint2.Task5.V10.Lib
{
    public class DataService : ISprint2Task5V10
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            string res;
            switch (m)
            {
                case 1:
                    switch (n)
                    {
                        case 1:
                            n = 31;
                            m = 12;
                            g -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        case 31:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 31. Значение - {n}");
                    }
                break;
                case 2:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 28. Значение - {n}");
                    }
                break;
                case 3:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        case 31:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 31. Значение - {n}");
                    }
                    break;
                case 4:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 30. Значение - {n}");
                    }
                    break;
                case 5:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        case 31:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 31. Значение - {n}");
                    }
                    break;
                case 6:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 30. Значение - {n}");
                    }
                    break;
                case 7:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        case 31:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 31. Значение - {n}");
                    }
                    break;
                case 8:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        case 31:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 31. Значение - {n}");
                    }
                    break;
                case 9:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 30. Значение - {n}");
                    }
                    break;
                case 10:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        case 31:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 31. Значение - {n}");
                    }
                    break;
                case 11:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 30. Значение - {n}");
                    }
                    break;
                case 12:
                    switch (n)
                    {
                        case 1:
                            n -= 1;
                            m -= 1;
                            break;
                        case 2:
                            n -= 1;
                            break;
                        case 3:
                            n -= 1;
                            break;
                        case 4:
                            n -= 1;
                            break;
                        case 5:
                            n -= 1;
                            break;
                        case 6:
                            n -= 1;
                            break;
                        case 7:
                            n -= 1;
                            break;
                        case 8:
                            n -= 1;
                            break;
                        case 9:
                            n -= 1;
                            break;
                        case 10:
                            n -= 1;
                            break;
                        case 11:
                            n -= 1;
                            break;
                        case 12:
                            n -= 1;
                            break;
                        case 13:
                            n -= 1;
                            break;
                        case 14:
                            n -= 1;
                            break;
                        case 15:
                            n -= 1;
                            break;
                        case 16:
                            n -= 1;
                            break;
                        case 17:
                            n -= 1;
                            break;
                        case 18:
                            n -= 1;
                            break;
                        case 19:
                            n -= 1;
                            break;
                        case 20:
                            n -= 1;
                            break;
                        case 21:
                            n -= 1;
                            break;
                        case 22:
                            n -= 1;
                            break;
                        case 23:
                            n -= 1;
                            break;
                        case 24:
                            n -= 1;
                            break;
                        case 25:
                            n -= 1;
                            break;
                        case 26:
                            n -= 1;
                            break;
                        case 27:
                            n -= 1;
                            break;
                        case 28:
                            n -= 1;
                            break;
                        case 29:
                            n -= 1;
                            break;
                        case 30:
                            n -= 1;
                            break;
                        case 31:
                            n -= 1;
                            break;
                        default:
                            throw new ArgumentException($"Число должно быть от 1 до 31. Значение - {n}");
                    }
                    break;
                    default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение - {m}");
            }
            res = $"{n}.{m}.{g}";
            if (n < 10)
            {
                res = $"0{n}.{m}.{g}";
            }
            if (m < 10)
            {
                res = $"{n}.0{m}.{g}";
            }
            if (g < 10)
            {
                res = $"{n}.{m}.0{g}";
            }
            if ((g < 10) && (m < 10))
            {
                res = $"{n}.0{m}.0{g}";
            }
            if ((g < 10) && (n < 10))
            {
                res = $"0{n}.{m}.0{g}";
            }
            if ((m < 10) && (n < 10))
            {
                res = $"0{n}.0{m}.{g}";
            }
            if ((g < 10) && (m < 10) && (n < 10))
            {
                res = $"0{n}.0{m}.0{g}";
            }
            return res;
        }
    }
}
