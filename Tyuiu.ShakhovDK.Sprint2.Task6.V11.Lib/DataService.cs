using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShakhovDK.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            DateTime dt = new DateTime(g, m, n);
            dt = dt.AddDays(1);
            return dt.ToString("d");
        }
    }
}
