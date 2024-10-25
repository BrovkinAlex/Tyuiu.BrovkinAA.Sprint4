using Tyuiu.BrovkinAA.Sprint4.Task7.V23.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task7.V23
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
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                     *");
            Console.WriteLine("* Задание #7                                                                  *");
            Console.WriteLine("* Вариант #23                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дана строка из одноразрядных цифр. Преобразуйте ее в матрицу 4 на 3         *");
            Console.WriteLine("* и подсчитайте количество четных чисел.                                      *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            string str = "678135972584";
            Console.WriteLine("Дана строка: " + str);

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int count = ds.Calculate(4, 3, str);
            Console.WriteLine("Количество четных чисел в строке: " + count);

            Console.ReadKey();
        }
    }
}
