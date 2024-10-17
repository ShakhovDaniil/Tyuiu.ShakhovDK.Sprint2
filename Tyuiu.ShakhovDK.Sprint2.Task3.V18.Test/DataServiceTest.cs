using Tyuiu.ShakhovDK.Sprint2.Task3.V18.Lib;
namespace Tyuiu.ShakhovDK.Sprint2.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 2;
            double wait = 36;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();

            double x = 0;
            double wait = 0.75;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();

            double x = -20;
            double wait = 0.951;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();

            double x = -24;
            double wait = -263.958;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}