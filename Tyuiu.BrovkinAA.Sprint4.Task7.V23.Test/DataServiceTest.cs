using Tyuiu.BrovkinAA.Sprint4.Task7.V23.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "657812549253";
            int res = ds.Calculate(4, 3, str);
            int wait = 5;

            Assert.AreEqual(wait, res);
        }
    }
}