using System.Net.Http.Headers;
using Tyuiu.NazarovSV.Sprint4.Task7.V28.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task7.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 5;
            int m = 3;
            int[,] matrx = new int[n, m];
            string str = "623351179845632";
            Console.WriteLine("**************************************************************************");
            int indx = 0;
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"{str[indx]} \t");
                    indx++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            int r = ds.Calculate(n, m, str);
            Console.WriteLine("Произведение чётных цифр равно = " + r);
            Console.ReadKey();
        }
    }
}
