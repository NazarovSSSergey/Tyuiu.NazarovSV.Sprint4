using System.Globalization;
using Tyuiu.NazarovSV.Sprint4.Task1.V7.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task1.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int len;
            Console.WriteLine("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());
            int[] nubmers = new int[len];
            for (int i = 0; i < len; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                nubmers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.Write(nubmers[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("РЕЗУЛЬТАТ: ");
            int res = ds.Calculate(nubmers);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
