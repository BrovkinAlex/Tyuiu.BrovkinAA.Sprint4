using Tyuiu.BrovkinAA.Sprint4.Task4.V14.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task4.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 4 | Выполнит Бровкин А. А. | ИБКСб-24-1";

            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* Спринт #4                                                                   *");
            Console.WriteLine("* Тема: двумерные массивы (ввод с клавиатуры)                                 *");
            Console.WriteLine("* Задание #4                                                                  *");
            Console.WriteLine("* Вариант #14                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный            *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8.                              *");
            Console.WriteLine("* Заменить нечетные элементы массива на 0.                                    *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            int[,] mas = { {1, 3, 7, 7, 6},
                           {4, 2, 6, 3, 3},
                           {4, 5, 1, 4, 6},
                           {7, 5, 2, 7, 7},
                           {2, 4, 4, 4, 7} };

            Console.WriteLine("Дан массив:");
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                    Console.Write($"{mas[i, j]}  ");
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
                    Console.Write($"{res[i, j]}  ");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
