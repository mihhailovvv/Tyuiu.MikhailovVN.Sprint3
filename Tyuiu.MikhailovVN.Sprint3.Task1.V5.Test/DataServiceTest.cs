
using Tyuiu.MikhailovVN.Sprint3.Task1.V5.Lib;
namespace Tyuiu.MikhailovVN.Sprint3.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 2.439;

            Assert.AreEqual(wait, res);
        }
    }
}
