using Tyuiu.BrovkinAA.Sprint4.Task3.V9.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = { { 4, 8, 4, 4, 6 }, { 3, 6, 4, 9, 7 }, { 9, 7, 5, 6, 7 }, { 9, 7, 3, 4, 3 }, { 8, 8, 3, 3, 3 } };
            int res = ds.Calculate(mas);
            int wait = 36;

            Assert.AreEqual(wait, res);
        }
    }
}