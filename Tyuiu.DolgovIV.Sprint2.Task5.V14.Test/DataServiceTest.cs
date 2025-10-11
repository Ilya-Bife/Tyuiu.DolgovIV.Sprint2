using Tyuiu.DolgovIV.Sprint2.Task5.V14.Lib;

namespace Tyuiu.DolgovIV.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 10;
            int d = 3;

            Assert.AreEqual(ds.FindDayName(k, d), "пятница");
        }
    }
}
