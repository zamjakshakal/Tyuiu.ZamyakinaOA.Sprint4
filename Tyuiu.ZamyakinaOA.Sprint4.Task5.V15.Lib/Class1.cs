using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task5.V15.Lib
{
    public class Class1 : ISprint4Task5V15
    {
        public int Calculate(int[,] matrix)
        {
            int sum = 0;
            int rows = matrix.GetUpperBound(0) + 1;
            int colums = matrix.Length / rows;

            for (int j = 0; j < rows; j++)
            {
                for (int k = 0; k < colums; k++)
                {
                    if (matrix[j, k] > 0)
                    {
                        sum += matrix[j, k];
                    }
                }
            }
            return sum;
        }
    }
}
