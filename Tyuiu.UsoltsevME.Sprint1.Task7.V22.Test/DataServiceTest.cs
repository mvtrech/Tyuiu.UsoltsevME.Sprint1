using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint1.Task7.V22.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 1;

            double wait = 1.113;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}