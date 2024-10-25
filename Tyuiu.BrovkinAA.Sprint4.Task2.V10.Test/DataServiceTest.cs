using Tyuiu.BrovkinAA.Sprint4.Task2.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] mas = { 1, 4, 3, 2, 3, 5, 2, 3, 1, 1, 6, 5, 3 };
            int res = ds.Calculate(mas);
            int wait = 2025;

            Assert.AreEqual(wait, res);
        }
    }
}