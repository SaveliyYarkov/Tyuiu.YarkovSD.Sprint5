using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            double a = Convert.ToDouble(File.ReadAllText(path).Replace(".", ","));

            return Math.Round(Math.Pow(a, -3) + 2 + Math.Cos(a), 3);
        }
    }
}
