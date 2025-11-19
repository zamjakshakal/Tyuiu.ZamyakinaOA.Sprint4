using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task2.V10.Lib
{
    public class Class1 : ISprint4Task2V10
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum *= array[i];
                }
            }
            return sum;
        }
    }
}
