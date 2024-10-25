using NuGet.Frameworks;
using Tyuiu.BrovkinAA.Sprint4.Task6.V11.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] mas = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int res = ds.Calculate(mas);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}