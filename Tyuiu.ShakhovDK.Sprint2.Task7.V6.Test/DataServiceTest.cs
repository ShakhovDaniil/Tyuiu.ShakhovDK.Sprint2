using Tyuiu.ShakhovDK.Sprint2.Task7.V6.Lib;
namespace Tyuiu.ShakhovDK.Sprint2.Task7.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = -1.1;
            double y = 1.2;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}