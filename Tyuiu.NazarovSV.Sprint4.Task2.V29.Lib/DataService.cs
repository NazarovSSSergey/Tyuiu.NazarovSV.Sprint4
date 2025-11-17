using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NazarovSV.Sprint4.Task2.V29.Lib
{
    public class DataService : ISprint4Task2V29
    {
        public int Calculate(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    p *= array[i];
                }
            }
            return p;
        }
    }
}
