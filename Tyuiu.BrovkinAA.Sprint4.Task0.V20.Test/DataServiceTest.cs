using Tyuiu.BrovkinAA.Sprint4.Task0.V20.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task0.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidMultEvenArr()
        {
            DataService ds = new DataService();
            int[] mas = new int[] { 4, 5, 6, 8, 9, 3, 4, 6, 7, 9 };
            int res = ds.GetMultEvenArrEl(mas);
            int wait = 4608;

            Assert.AreEqual(wait, res);
        }
    }
}