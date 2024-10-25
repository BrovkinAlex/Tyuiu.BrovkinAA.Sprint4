using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrovkinAA.Sprint4.Task2.V10.Lib
{
    public class DataService : ISprint4Task2V10
    {
        public int Calculate(int[] array)
        {
            int prod = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    prod *= array[i];
            }

            return prod;
        }
    }
}
