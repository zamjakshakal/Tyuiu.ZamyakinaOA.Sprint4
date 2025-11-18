using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task1.V19.Lib
{
    public class Class1 : ISprint4Task1V19
    {
        public int Calculate(int[] array)
        {
            int res = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res += array[i];
                }
            }
            return res;
        }
    }
}
