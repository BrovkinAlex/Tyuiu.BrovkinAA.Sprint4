using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrovkinAA.Sprint4.Task1.V24.Lib
{
    public class DataService : ISprint4Task1V24
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
