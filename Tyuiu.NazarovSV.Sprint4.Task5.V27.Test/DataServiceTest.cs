using Tyuiu.NazarovSV.Sprint4.Task5.V27.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] mass = new int[5, 5] { { -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1 }, { -1, -1, -1, -1, -1 } };
            int res = ds.Calculate(mass);
            int next = 25;
            Assert.AreEqual(next, res);
        }
    }
}
