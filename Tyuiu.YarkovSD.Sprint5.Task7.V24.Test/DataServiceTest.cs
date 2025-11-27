using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.YarkovSD.Sprint5.Task7.V24.Lib;

namespace Tyuiu.YarkovSD.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";
            string testData = "Привет, World! This моя Первая программа.";
            File.WriteAllText(path, testData, Encoding.UTF8);

            DataService ds = new DataService();
            string resultPath = ds.LoadDataAndSave(path);

            string result = File.ReadAllText(resultPath, Encoding.UTF8);
            string wait = "слово, World! This слово слово слово.";

            Assert.AreEqual(wait, result);
        }
    }
}
