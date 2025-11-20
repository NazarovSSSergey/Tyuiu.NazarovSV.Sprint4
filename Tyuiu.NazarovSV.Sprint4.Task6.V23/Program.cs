using Tyuiu.NazarovSV.Sprint4.Task6.V23.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            string[] progs = { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            int res = ds.Calculate(progs);
            Console.WriteLine("РЕЗУЛЬТАТ: ");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
