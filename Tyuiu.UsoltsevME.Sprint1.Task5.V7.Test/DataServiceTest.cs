using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint1.Task5.V7.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double f = 75;

            int wait = 2;

            int res = ds.AngleToHoursMinutes(f);

            Assert.AreEqual(wait, res);
        }
    }
}