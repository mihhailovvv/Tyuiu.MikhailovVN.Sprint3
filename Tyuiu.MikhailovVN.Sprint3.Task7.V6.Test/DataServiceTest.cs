
using Tyuiu.MikhailovVN.Sprint3.Task7.V6.Lib;
namespace Tyuiu.MikhailovVN.Sprint3.Task7.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = (stopValue - startValue) + 1;
            double[] wait = new double[len];

            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if ((4 * x - 0.5) == 0)
                {
                    wait[count] = 0;
                }
                else
                {
                    double y = (3 * Math.Cos(x)) / (4 * x - 0.5) + Math.Sin(x) - 5 * x - 2;
                    wait[count] = Math.Round(y, 2);
                }
                count++;
            }

            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
