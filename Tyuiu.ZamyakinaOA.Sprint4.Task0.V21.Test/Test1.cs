using Tyuiu.ZamyakinaOA.Sprint4.Task0.V21.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint4.Task0.V21.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ds = new Class1();
            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            int res = 6;
            Assert.AreEqual(ds.GetSumEvenArrEl(array), res);
        }
    }
}
