using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrovkinAA.Sprint4.Task3.V9.Lib
{
    public class DataService : ISprint4Task3V9
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
                sum += array[i, 1];

            return sum;
        }
    }
}
