using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task6.V2.Lib
{
    public class DataSevice : ISprint5Task6V2
    {
        public int LoadFromDataFile(string path)
        {

            // Используем регулярное выражение для поиска русских букв
            int count = Regex.Matches(path, @"[А-Яа-яЁё]").Count;

            return count;
        }
    }
}
