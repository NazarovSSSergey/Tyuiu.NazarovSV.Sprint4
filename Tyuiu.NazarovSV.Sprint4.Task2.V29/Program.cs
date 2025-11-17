using Tyuiu.NazarovSV.Sprint4.Task2.V29.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите количество элементов массива: ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[len];
            for (int i = 0; i < len; i++)
            {
                numbers[i] = rnd.Next(1, 8);
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(numbers[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("РЕЗУЛЬТАТ: ");
            int res = ds.Calculate(numbers);
            Console.WriteLine("Произведение чётных чисел массива = " + res);
            Console.ReadKey();
        }
    }
}
