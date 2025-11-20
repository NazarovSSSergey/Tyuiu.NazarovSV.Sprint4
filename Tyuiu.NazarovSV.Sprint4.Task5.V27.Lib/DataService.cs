using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NazarovSV.Sprint4.Task5.V27.Lib
{
    public class DataService : ISprint4Task5V27
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;

            int c = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}
