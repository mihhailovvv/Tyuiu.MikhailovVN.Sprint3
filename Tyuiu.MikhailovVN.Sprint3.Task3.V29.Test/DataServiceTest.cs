
using Tyuiu.MikhailovVN.Sprint3.Task3.V29.Lib;
namespace Tyuiu.MikhailovVN.Sprint3.Task3.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "chgr vhhtg hnht";
            char item = 'h';

            string res = ds.DeleteCharInString(value, item);
            string wait = "cgr vtg nt";

            Assert.AreEqual(res, wait);
        }
    }
}
