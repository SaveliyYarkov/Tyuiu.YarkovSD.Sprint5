using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task5.V23.Lib
{
    public class DataService : ISprint5Task5V23
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);
            string[] numberStrings = text.Split(',');

            double minValue = double.MaxValue;

            foreach (string numberStr in numberStrings)
            {
                if (double.TryParse(numberStr.Trim(), out double number))
                {
                    if (number < minValue)
                    {
                        minValue = number;
                    }
                }
            }
            return Math.Round(minValue, 3);
        }
    }
}
