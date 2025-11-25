using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task2.V16.Lib
{
    public class DataService : ISprint5Task2V16
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string a = "";

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;

                    if (j != matrix.GetLength(1) - 1) a += ";";
                    else if (i != matrix.GetLength(0) - 1) a += Environment.NewLine;
                }
            }

            return a;
        }
    }
}
