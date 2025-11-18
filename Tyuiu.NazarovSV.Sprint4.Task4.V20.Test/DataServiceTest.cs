using Tyuiu.NazarovSV.Sprint4.Task4.V20.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 4, 5, 5, 6, 4 }, { 7, 8, 4, 7, 5 }, { 5, 6, 5, 8, 5 }, { 7, 5, 8, 7, 8 }, { 4, 7, 7, 8, 8 } };
            int[,] next = new int[5, 5] { { 1, 5, 5, 1, 1 }, { 7, 1, 1, 7, 5 }, { 5, 1, 5, 1, 5 }, { 7, 5, 1, 7, 1 }, { 1, 7, 7, 1, 1 } };
            int[,] res = ds.Calculate(mas2);
            CollectionAssert.AreEqual(next, res);
        }
    }
}
