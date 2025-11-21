using System.Diagnostics.Metrics;
using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.NazarovSV.Sprint4.Task7.V28.Lib
{
    public class DataService : ISprint4Task7V28
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrx = new int[n, m];
            int p = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrx[i, j] % 2 == 0)
                    {
                        p *= matrx[i, j];
                    }
                }
            }
            return p;
        }
    }
}
