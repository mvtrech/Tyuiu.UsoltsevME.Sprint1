using Tyuiu.UsoltsevME.Sprint1.Task3.V12.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task3.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 4;
            double b = 3;
            double walt = 6;
            var res = ds.TriangleArea(a, b);
            Assert.AreEqual(walt, res);

        }
    }
}
