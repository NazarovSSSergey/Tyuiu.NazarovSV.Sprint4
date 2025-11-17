using Tyuiu.NazarovSV.Sprint4.Task0.V3.Lib;
namespace Tyuiu.NazarovSV.Sprint4.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int[] array = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Данные массива: { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 }");
            int res = ds.GetMultOddArrEl(array);
            Console.WriteLine("Результат произведения нечётных чисел массива: " + res);
            Console.ReadKey();
        }
    }
}
