using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.HubulovaVI.Sprint7.Lib;
using System.IO;

namespace Tyuiu.HubulovaVI.Sprint7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string filePath = @"C:\Users\valeria\source\repos\Tyuiu.HubulovaVI.Sprint7.V5\Tyuiu.HubulovaVI.Sprint7\bin\Debug\DataBase.csv";

            AddDataToCSV(filePath);
        }

        private void AddDataToCSV(string filePath)
        {
            try
            {
                using (var writer = new StreamWriter(filePath, true)) // открытие файла для записи
                {
                    // Пример добавления строчки 
                    writer.WriteLine("Артикул; Отдел");
                }
            }
            catch (Exception ex)
            {
                // Проверка на ошибки
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}


