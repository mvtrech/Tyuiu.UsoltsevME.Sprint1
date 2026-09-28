using Tyuiu.UsoltsevME.Sprint1.Task1.V7.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task1.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.6666666666666667, res);

        }
    }
}
