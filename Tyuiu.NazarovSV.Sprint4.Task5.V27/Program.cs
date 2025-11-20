using Tyuiu.NazarovSV.Sprint4.Task5.V27.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task5.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите количество строк массива: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов массива: ");
            int coms = Convert.ToInt32(Console.ReadLine());

            int[,] m = new int[rows, coms];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < coms; j++)
                {
                    m[i, j] = rnd.Next(-5, 7);
                }
            }

            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j =0; j < coms; j++)
                {
                    Console.Write($"{m[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("РЕЗУЛЬТАТ: ");
            int r = ds.Calculate(m);
            Console.WriteLine("Количество отрицательных значений в массиве - " + r);
            Console.ReadKey();
        }
    }
}
