using Tyuiu.ShakhovDK.Sprint2.Task4.V26.Lib;

namespace Tyuiu.ShakhovDK.Sprint2.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ConditionTrue()
        {
            DataService ds = new DataService();
            double x = 1, y = 1;
            var wait = 12;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ConditionFalse()
        {
            DataService ds = new DataService();
            double x = 5, y = 2;
            var wait = 24.5;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}