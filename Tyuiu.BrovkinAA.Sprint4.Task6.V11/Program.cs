using Tyuiu.BrovkinAA.Sprint4.Task6.V11.Lib;
namespace Tyuiu.BrovkinAA.Sprint4.Task6.V11
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
            Console.WriteLine("* Тема: Класс Array                                                           *");
            Console.WriteLine("* Задание #6                                                                  *");
            Console.WriteLine("* Вариант #11                                                                 *");
            Console.WriteLine("* Выполнил Бровкин Алексей Александрович | ИБКСб-24-1                         *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("* УСЛОВИЕ:                                                                    *");
            Console.WriteLine("* Дан строковый массив данных, используя класс Array                          *");
            Console.WriteLine("* подсчитайте количество элементов, длина которых равна 5.                    *");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                            *");
            Console.WriteLine("*******************************************************************************\n");

            string[] mas = { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            Console.WriteLine("Дан массив:\n");
            Console.Write($"'{mas[0]}'");
            for (int i = 1; i < mas.Length; i++)
                Console.Write($", '{mas[i]}'");

            Console.WriteLine("\n*******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                  *");
            Console.WriteLine("*******************************************************************************\n");

            int count = ds.Calculate(mas);
            Console.WriteLine("Количество элементов, длина которых равна 5: " + count);

            Console.ReadKey();
        }
    }
}
