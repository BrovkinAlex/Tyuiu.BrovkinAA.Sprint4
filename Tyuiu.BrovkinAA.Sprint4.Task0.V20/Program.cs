using Tyuiu.BrovkinAA.Sprint4.Task0.V20.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task0.V20
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
            Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                                 *");
            Console.WriteLine("* Задание #0                                                                  *");
            Console.WriteLine("* Вариант #20                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный             *");
            Console.WriteLine("* статическими значениями в диапазоне от 0 до 9                               *");
            Console.WriteLine("* подсчитать произведение четных элементов массива.                           *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            int[] mas = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };
            Console.WriteLine("Дан массив:");
            for (int i = 0; i < mas.Length; i++)
                Console.Write(mas[i] + "\t");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int res = ds.GetMultEvenArrEl(mas);
            Console.WriteLine("Произведение четных элементов массива: " + res);

            Console.ReadKey();
        }
    }
}
