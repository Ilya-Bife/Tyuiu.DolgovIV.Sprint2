using Tyuiu.DolgovIV.Sprint2.Task4.V1.Lib;

namespace Tyuiu.DolgovIV.Sprint2.Task4.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 1;
            double y = 2;

            DataService ds = new DataService();

            Assert.AreEqual(ds.Calculate(x, y), 2);
        }
    }
}
