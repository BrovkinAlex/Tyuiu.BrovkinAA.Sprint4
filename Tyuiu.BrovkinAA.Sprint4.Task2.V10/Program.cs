using Tyuiu.BrovkinAA.Sprint4.Task2.V10.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task2.V10
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
            Console.WriteLine("* Тема: Одномерные массивы (генератор случайных чисел)                        *");
            Console.WriteLine("* Задание #1                                                                  *");
            Console.WriteLine("* Вариант #10                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный             *");
            Console.WriteLine("* случайными в диапазоне от 1 до 6                                            *");
            Console.WriteLine("* подсчитать произведение нечетных элементов массива.                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            int[] mas = new int[16];
            Console.WriteLine("Сгенерирован массив  случайных чисел:");
            for (int i = 0; i < mas.Length; i++)            
                Console.Write($"{mas[i] = rand.Next(1, 6)}  ");

            Console.WriteLine("\n\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int res = ds.Calculate(mas);
            Console.WriteLine("Произведение нечетных элементов массива: " + res);

            Console.ReadKey();
        }
    }
}
