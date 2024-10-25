using Tyuiu.BrovkinAA.Sprint4.Task5.V11.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task5.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rand = new Random();

            Console.Title = "Спринт 4 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #4                                                                   *");
            Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                        *");
            Console.WriteLine("* Задание #5                                                                  *");
            Console.WriteLine("* Вариант #11                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный            *");
            Console.WriteLine("* случайными значениями в диапазоне от -7 до 2.                               *");
            Console.WriteLine("* Заменить положительные элементы на 1.                                       *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            int[,] mas = new int[5, 5];
            Console.WriteLine("Дан массив:");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write($"{mas[i, j] = rand.Next(-7, 3)}\t");
                Console.WriteLine();
            }

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int[,] res = ds.Calculate(mas);
            Console.WriteLine("Преобразованный массив:");
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                    Console.Write($"{res[i, j]}\t");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
