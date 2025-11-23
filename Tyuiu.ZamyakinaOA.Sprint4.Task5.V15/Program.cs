using Tyuiu.ZamyakinaOA.Sprint4.Task5.V15.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task0.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 ds = new Class1();
            Random rand = new Random();

            Console.Title = "Спринт #4 | Выполнила: Замякина О. А. | ПКТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Замякина Олеся Андреевна | ПКТб-25-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда     *");
            Console.WriteLine("* по формуле, при a = 0,5                                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int colums = 5;
            int[,] matrix = new int[rows, colums];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; i < colums; j++)
                {
                    matrix[i, j] = rand.Next(-6, 4);
                }
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            
        }
    }
}