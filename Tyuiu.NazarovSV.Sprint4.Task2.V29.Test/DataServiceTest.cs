using Tyuiu.NazarovSV.Sprint4.Task2.V29.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task2.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] numbers = { 5, 1, 7, 3, 1, 2, 1, 7, 2, 1, 6 };
            int res = ds.Calculate(numbers);
            int next = 24;
            Assert.AreEqual(next, res);
        }
    }
}
