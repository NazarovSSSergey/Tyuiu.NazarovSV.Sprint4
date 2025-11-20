using Tyuiu.NazarovSV.Sprint4.Task6.V23.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task6.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var prog = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            int res = ds.Calculate(prog);
            int next = 2;
            Assert.AreEqual(next, res);
        }
    }
}
