using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task3.V10.Lib
{
    public class Class1 : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;

            int maxx = 0;

            for (int j = 0; j < colums; j++)
            {
                if (array[3, j] >  maxx)
                    {
                        maxx = array[3, j];
                    }
            }
            return maxx;
        }
    }
}
