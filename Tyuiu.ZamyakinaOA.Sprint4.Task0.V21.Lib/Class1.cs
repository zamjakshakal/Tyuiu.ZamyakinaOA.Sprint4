using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task0.V21.Lib
{
    public class Class1 : ISprint4Task0V21
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int res = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    res = res + array[i];
                }
            }
            return res;
        }
    }
}
