using Tyuiu.DolgovIV.Sprint2.Task2.V4.Lib;

namespace Tyuiu.DolgovIV.Sprint2.Task2.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            bool wait = true;
            int x = 3;
            int y = 2;
            Assert.AreEqual(wait, ds.CheckDotInShadedArea(x, y));
        }
    }
}
