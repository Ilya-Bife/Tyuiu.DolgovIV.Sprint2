using Tyuiu.DolgovIV.Sprint2.Task6.V12.Lib;

namespace Tyuiu.DolgovIV.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int g = 2000;
            int m = 4;
            int n = 1;



            Assert.AreEqual(ds.FindDateOfPreviousDay(g, m, n), "31.03.2000");
        }
    }
}
