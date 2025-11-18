using Tyuiu.NazarovSV.Sprint4.Task4.V20.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов в массиве: ");
            int colums = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rows, colums];
            Console.WriteLine("**************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("РЕЗУЛЬТАТ:            ");
            int[,] res = ds.Calculate(matrix);
            Console.WriteLine("Массив примет следующий вид - " + res);
            Console.ReadKey();
        }
    }
}
