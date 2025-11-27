using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path, Encoding.UTF8);

            string res = Regex.Replace(content, @"\b[А-Яа-яЁё]+(-[А-Яа-яЁё]+)*\b", "слово");

            string outputPath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V24.txt");

            File.WriteAllText(outputPath, res, Encoding.UTF8);

            return outputPath;
        }
    }
}