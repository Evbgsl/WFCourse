using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public class DataFileProvider
    {
        //public string FileName { get; set; }
        //public static void Append(string fileName, string value)
        //{
        //    var writer = new StreamWriter(fileName, true, Encoding.UTF8);
        //    writer.WriteLine(value);
        //    writer.Close();
        //}

        //public static void Append(string fileName, string[] value, bool rewrite)
        //{
        //    using (StreamWriter writer = new StreamWriter(fileName))
        //    {
        //        foreach (string line in value)
        //        {
        //            writer.WriteLine(line);
        //        }
        //        writer.Close();
        //    }
        //}


        //public static void Replace(string fileName, string value, bool rewrite)
        //{
        //    using (StreamWriter writer = new StreamWriter(fileName))
        //    {
        //        writer.WriteLine(value);
        //        writer.Close();
        //    }
        //}

        public static string GetValue(string fileName)
        {
            var reader = new StreamReader(fileName, Encoding.UTF8);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;
        }

        public static void CheckResultFile(string resultsDataFilePath)
        {
            if (!File.Exists(resultsDataFilePath))
            {
                try
                {
                    File.WriteAllText(resultsDataFilePath, string.Empty);
                    MessageBox.Show("Создан новый файл с результатами");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }




    }
}