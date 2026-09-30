using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint1.Task6.V14.Lib;

namespace Tyuiu.UsoltsevME.Sprint1.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string value = "привет";

            bool wait = true;

            bool res = ds.CheckLowerCaseRusLetters(value);

            Assert.AreEqual(wait, res);
        }
    }
}