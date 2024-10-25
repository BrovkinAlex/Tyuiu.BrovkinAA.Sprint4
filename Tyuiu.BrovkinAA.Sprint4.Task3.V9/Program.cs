using Tyuiu.BrovkinAA.Sprint4.Task3.V9.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task3.V9
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
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                  *");
            Console.WriteLine("* Задание #3                                                                  *");
            Console.WriteLine("* Вариант #9                                                                  *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный            *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9.                              *");
            Console.WriteLine("* Найдите сумму элементов во втором столбце массива.                          *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            int[,] mas = { { 9, 6, 4, 5, 3 }, 
                           { 7, 4, 7, 5, 3 }, 
                           { 8, 5, 9, 9, 3 },
                           { 7, 8, 7, 9, 3 },
                           { 3, 7, 3, 7, 7 } };

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

            int res = ds.Calculate(mas);
            Console.WriteLine("Cуммa элементов во втором столбце массива: " + res);

            Console.ReadKey();
        }
    }
}
