using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task6.V9.Lib
{
    public class Class1 : ISprint4Task6V9
    {
        public int Calculate(string[] array)
        {
            string[] mas = Array.FindAll(array, x => x.Length < 7);
            return mas.Length;
        }
    }
}
