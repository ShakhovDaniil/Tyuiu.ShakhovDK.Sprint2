using Tyuiu.ShakhovDK.Sprint2.Task5.V10.Lib;
namespace Tyuiu.ShakhovDK.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 1;
            int n = 1;
            var res = ds.FindDateOfPreviousDay(g, m, n);
            var wait = "31.12.2023";
            Assert.AreEqual(wait, res);
        }
    }
}