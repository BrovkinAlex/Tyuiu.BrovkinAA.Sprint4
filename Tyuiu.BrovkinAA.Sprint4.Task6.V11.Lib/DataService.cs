using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrovkinAA.Sprint4.Task6.V11.Lib
{
    public class DataService : ISprint4Task6V11
    {
        public int Calculate(string[] array)
        {
            int count = array.Count(c => c.Length == 5);
            return count;
        }
    }
}
