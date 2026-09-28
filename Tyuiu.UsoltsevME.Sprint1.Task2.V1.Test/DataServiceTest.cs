using Tyuiu.UsoltsevME.Sprint1.Task2.V1.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1609;
            var res = ds.ConvertKmToM(x);
            Assert.AreEqual(1.000, res);

        }
    }
}
