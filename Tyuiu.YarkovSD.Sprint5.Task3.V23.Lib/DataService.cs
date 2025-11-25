
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.YarkovSD.Sprint5.Task3.V23.Lib
{
    public class DataService : ISprint5Task3V23
    {
        public string SaveToFileTextData(int x)
        {
            string outputFile = "OutPutFileTask3.bin";

            string path = Path.Combine(Path.GetTempPath(), outputFile);

            FileInfo fileInfo = new(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) File.Delete(path);

            double r = Math.Round((1 + Math.Pow(x, 3)) / Math.Pow(x, 2));

            using (BinaryWriter writer = new(File.Open(path, FileMode.Append)))
            {
                writer.Write(r);
            }
            return path;
        }
    }
}
