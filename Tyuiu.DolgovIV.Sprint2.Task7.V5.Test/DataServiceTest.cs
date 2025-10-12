using Tyuiu.DolgovIV.Sprint2.Task7.V5.Lib;

namespace Tyuiu.DolgovIV.Sprint2.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0.5;

            Assert.AreEqual(ds.CheckDotInShadedArea(x, y), true);


        }
    }
}
