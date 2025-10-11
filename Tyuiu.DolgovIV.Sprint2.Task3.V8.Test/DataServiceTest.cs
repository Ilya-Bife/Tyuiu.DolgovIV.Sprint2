using Tyuiu.DolgovIV.Sprint2.Task3.V8.Lib;

namespace Tyuiu.DolgovIV.Sprint2.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 0;
            DataService ds = new DataService();

            Assert.AreEqual(ds.Calculate(x), 0.75);
        }
    }
}
