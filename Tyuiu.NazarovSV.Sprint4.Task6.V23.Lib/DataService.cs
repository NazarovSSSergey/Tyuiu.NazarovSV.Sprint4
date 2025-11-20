using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NazarovSV.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            string[] progs = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            return progs.Count(n => n.Length == 6);
        }
    }
}
