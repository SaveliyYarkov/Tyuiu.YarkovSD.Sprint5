using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task6.V2.Lib
{
    public class DataService : ISprint5Task6V2
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path, Encoding.UTF8);
            int count = Regex.Matches(content, @"[А-Яа-яЁё]").Count;

            return count;
        }
    }
}
