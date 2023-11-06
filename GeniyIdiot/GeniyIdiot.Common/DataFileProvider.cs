using System.IO;
using System.Text;
using static System.Windows.Forms.LinkLabel;

namespace GeniyIdiot.Common
{

    public class DataFileProvider
    {
        public string FileName { get; set; }
        public static void Append(string fileName, string value)
        {
            var writer = new StreamWriter(fileName, true, Encoding.UTF8);
            writer.WriteLine(value);
            writer.Close();
        }

        public static void Append(string fileName, string[] value, bool rewrite)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (string line in value)
                {
                    writer.WriteLine(line);
                }
                writer.Close();
            }
        }


        public static string GetValue(string fileName)
        {
            var reader = new StreamReader(fileName, Encoding.UTF8);
            var value = reader.ReadToEnd();
            reader.Close();
            return value;
        }
    }



}
