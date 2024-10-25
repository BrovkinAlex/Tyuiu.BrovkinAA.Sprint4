using Tyuiu.BrovkinAA.Sprint4.Task1.V24.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task1.V24
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
            Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                                *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #24                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 16 элементов заполненный             *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 5                               *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            int[] mas = new int[16];
            Console.WriteLine("Введите массив:");
            for (int i = 0; i < mas.Length; i++)
                mas[i] = Convert.ToInt32(Console.Read());

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int res = ds.Calculate(mas);
            Console.WriteLine("Произведение нечетных элементов массива: " + res);

            Console.ReadKey();
        }
    }
}
