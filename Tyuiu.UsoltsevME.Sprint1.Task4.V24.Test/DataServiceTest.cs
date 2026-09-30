using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint1.Task4.V24.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task4.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 2;

            double wait = 0.287;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}