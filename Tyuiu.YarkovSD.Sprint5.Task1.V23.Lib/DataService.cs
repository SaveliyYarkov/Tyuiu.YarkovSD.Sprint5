using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task1.V23.Lib
{
    public class DataService : ISprint5Task1V23
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string a = "";

            for (double x = startValue; x <= stopValue; x += 1)
            {
                double result;
                if (x + 2 == 0)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Round(Math.Cos(x) + (Math.Cos(x) / (x + 2)) - 3 * x, 2);
                }
                a += Convert.ToString(result);
            }

            return a;
        }
    }
}