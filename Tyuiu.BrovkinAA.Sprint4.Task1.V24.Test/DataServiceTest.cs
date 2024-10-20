using Tyuiu.BrovkinAA.Sprint4.Task1.V24.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] mas = { 4, 3, 4, 5, 3, 5, 2, 2, 5, 2, 2, 5, 5, 3, 3, 3 };
            int res = ds.Calculate(mas);
            double wait = 759375;

            Assert.AreEqual(wait, res);
        }
    }
}