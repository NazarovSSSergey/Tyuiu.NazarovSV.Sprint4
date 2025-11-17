using Tyuiu.NazarovSV.Sprint4.Task3.V23.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task3.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas2 = new int[5, 5] { { 7, 5, 5, 6, 7 }, { 8, 7, 8, 4, 3 }, { 5, 6, 7, 8, 3 }, { 4, 2, 3, 6, 4 }, { 5, 2, 4, 2, 3 } };
            int rows = mas2.GetUpperBound(0) + 1;
            int colums = mas2.Length / rows;
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{mas2[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("РЕЗУЛЬТАТ ");
            int res = ds.Calculate(mas2);
            Console.WriteLine("Количество чётных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
