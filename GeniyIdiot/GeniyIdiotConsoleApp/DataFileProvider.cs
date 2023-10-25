using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;

public class DataFileProvider
{
    public string? FileName { get; set; }
    public static void Append(string fileName, string value)
    {
        var writer = new StreamWriter(fileName, true, Encoding.UTF8);
        writer.WriteLine(value);
        writer.Close();
    }

    public static void Append(string fileName, string[] value, bool rewrite)
    {
        var writer = new StreamWriter(fileName, rewrite, Encoding.UTF8);
        writer.WriteLine(value);
        writer.Close();
    }


    public static string GetValue(string fileName)
    {
        var reader = new StreamReader(fileName, Encoding.UTF8);
        var value = reader.ReadToEnd();
        reader.Close();
        return value;
    }
 }