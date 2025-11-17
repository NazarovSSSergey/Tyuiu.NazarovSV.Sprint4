using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NazarovSV.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] array)
        {
            int[] numbers = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int p = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    p *= i;
                }
            }
            return p;
        }
    }
}
