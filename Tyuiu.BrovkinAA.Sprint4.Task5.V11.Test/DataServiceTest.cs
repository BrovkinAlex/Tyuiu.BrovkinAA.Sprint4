using Tyuiu.BrovkinAA.Sprint4.Task5.V11.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task5.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas = { { 1, 0, -4, -1, -7 }, { -1, -2, 0, -4, -6 }, { -2, -7, -6, 2, -5 }, { -2, -1, 2, -6, -5}, { -5, 0, -4, -2, -3} };
            int[,] res = ds.Calculate(mas);
            int[,] wait = { { 1, 0, -4, -1, -7 }, { -1, -2, 0, -4, -6 }, { -2, -7, -6, 1, -5 }, { -2, -1, 1, -6, -5 }, { -5, 0, -4, -2, -3 } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}