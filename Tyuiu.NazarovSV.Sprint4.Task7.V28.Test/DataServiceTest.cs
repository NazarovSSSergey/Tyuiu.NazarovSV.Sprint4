using System.Net.Http.Headers;
using Tyuiu.NazarovSV.Sprint4.Task7.V28.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task7.V28.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "623351179845632";
            int res = ds.Calculate(n, m, str);
            int next = 4608;
            Assert.AreEqual(next, res);
        }
    }
}
