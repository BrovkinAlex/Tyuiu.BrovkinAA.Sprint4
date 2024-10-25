using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.BrovkinAA.Sprint4.Task7.V23.Lib
{
    public class DataService : ISprint4Task7V23
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mas = new int[n, m];
            int count = 0;

            int strInd = 0;
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = 0; j < mas.GetLength(1); j++)
                    count += ((mas[i, j] = value[strInd++]) % 2 == 0) ? 1 : 0;
            
            return count;
        }
    }
}
