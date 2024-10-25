using Tyuiu.BrovkinAA.Sprint4.Task4.V14.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = { { 6, 2, 5, 6, 6 }, { 8, 1, 8, 6, 2 }, { 3, 3, 4, 1, 1 }, { 4, 8, 8, 5, 7 }, { 3, 6, 3, 5, 7 } };
            int[,] res = ds.Calculate(mas);
            int[,] wait = { { 6, 2, 0, 6, 6 }, { 8, 0, 8, 6, 2 }, { 0, 0, 4, 0, 0 }, { 4, 8, 8, 0, 0 }, { 0, 6, 0, 0, 0 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}