using System;
using System.IO;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;

public class DataFileProvider
{
    public string? DataFilePath { get; set; }

    public static List<Question> GetQuestionsFromFile(string path)
    {
        using (StreamReader sr = new StreamReader(path))
        {
            var questionsFromFile = new List<Question>();
            string? line;
            while ((line = sr.ReadLine()) != null)
            { 
                if (line.StartsWith("question#"))
                {
                    var _question = line.Split('@');
                    questionsFromFile.Add(new Question(_question[1], _question[2], Convert.ToInt32(_question[3])));
                }
                
            }
            return questionsFromFile;
        }
        
    }

    public static void GetResultsFromFile(string path)
    {

        Console.WriteLine("{0,20} | {1,20} | {2, 20}", "ФИО", "% верных ответов", "Диагноз");
        using (StreamReader sr = new StreamReader(path))
        {
            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.StartsWith("result#"))
                {
                    var lineArray = line.Split("@");
                    Console.WriteLine("{0,20} | {1,20} | {2,20}", lineArray[1], lineArray[2], lineArray[3]);
                }
            }
        }

    }


    public static void SetQuestionToFile(string path)
    {
        while (true)
        {
            try
            {
                var stringForQuestion = Console.ReadLine().Split('&');
                var id = Guid.NewGuid().ToString().Remove(6);
                var newQuestion = new Question(id, stringForQuestion[0], Convert.ToInt32(stringForQuestion[1]));
                using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine($"question#@{newQuestion.Id}@{newQuestion.Text}@{newQuestion.Answer}");
                    Console.WriteLine("Вопрос сохранен");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " Неверный формат вопроса");
            }
        }
    }

    public static void RemoveQuestionFromFile(string path, string id)
    {
        var readText = File.ReadAllLines(path).ToList();
        var readTextArray = readText.Where(line => (line.Split('@')[1] != id)).Select(line => line).ToArray();
        if (readText.Count > readTextArray.Length)
        {
            Console.WriteLine("Вопрос удален");
        }
        else Console.WriteLine("Вопроса с таким ID не существует");
        
        File.WriteAllLines(path, readTextArray);//записываем строки назад в файл
    }

    public static void SetResultToFile(User user, int percentOfRightAnswers, string userDiagnose, string path)
    {
        using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
        {
            var _testResult = $"result#@{user.Name}@{percentOfRightAnswers}@{userDiagnose}";
            sw.WriteLine(_testResult);
        }

    }

}