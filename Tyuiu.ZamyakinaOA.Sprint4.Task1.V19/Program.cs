using Tyuiu.ZamyakinaOA.Sprint4.Task1.V19.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task1.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ds = new Class1();
            Console.Title = "Спринт #4 | Выполнила: Замякина О. А. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнила: Замякина Олеся Андреевна | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
            Console.WriteLine("* по формуле, при a = 0,5                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = Convert.ToInt32(Console.ReadLine());
            int[] numsarray = new int[len];

            for (int i  = 0; i <= len-1; i++)
            {
                numsarray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.Calculate(numsarray));
        }
    }
}