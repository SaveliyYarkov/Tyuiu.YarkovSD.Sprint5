using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task0.V29.Lib
{
    public class DataService : ISprint5Task0V29
    {
        public string SaveToFileTextData(int x)
        {
            double result = 6.1 * Math.Pow(x, 3) + 0.23 * Math.Pow(x, 2) + 1.04 * x;
            result = Math.Round(result, 3);
            return Convert.ToString(result);
        }
    }
}

