using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.YarkovSD.Sprint5.Task7.V24.Lib;

namespace Tyuiu.YarkovSD.Sprint5.Task7.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(@"C:", "DataSprint5", "InPutDataFileTask7V24.txt");
            string fileContent = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine("Исходный текст:");
            Console.WriteLine(fileContent);

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string resultPath = ds.LoadDataAndSave(path);

            string resultContent = File.ReadAllText(resultPath, Encoding.UTF8);

            Console.WriteLine("Содержимое обработанного файла:");
            Console.WriteLine(resultContent);

            Console.ReadKey();
        }
    }
}