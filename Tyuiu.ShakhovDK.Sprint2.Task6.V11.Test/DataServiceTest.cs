using Tyuiu.ShakhovDK.Sprint2.Task6.V11.Lib;
namespace Tyuiu.ShakhovDK.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2000;
            int m = 5;
            int n = 7;
            var res = ds.FindDateOfNextDay(g, m, n);
            var wait = "08.05.2000";
            Assert.AreEqual(wait, res);
        }
    }
}