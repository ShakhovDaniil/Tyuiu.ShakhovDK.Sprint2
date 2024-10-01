using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShakhovDK.Sprint2.Task0.V16.Lib
{
    public class DataService : ISprint2Task0V16
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            DataService ds = new DataService();

            bool[] res = new bool[6];

            res[0] = (x - 750) == y;

            res[1] = (x - 750) != y;

            res[2] = (x - 751) < y;

            res[3] = (x - 751) > y;

            res[4] = (x - 750) <= y;

            res[5] = (x - 751) >= y;

            return res;
        }
    }
}
