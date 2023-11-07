using System.Collections.Generic;
using System.Linq;
using System;

namespace GeniyIdiot.Common
{
    public class QuestionsStorage
    {
        public Question Questions;

        public QuestionsStorage(Question questions)
        {
            Questions = questions;
        }

        public Question GetQuestion(List<Question> questions, int index)
        {
            return questions[index];
        }


        public static List<Question> GetQuestions(string value)
        {
            var questionsFromFile = new List<Question>();
            var lines = value.Split('\n');
            foreach (var line in lines)
                if (line.StartsWith("question#"))
                {
                    var _question = line.Split('@');
                    questionsFromFile.Add(new Question(_question[1], _question[2], Convert.ToInt32(_question[3])));
                }
            return questionsFromFile;
        }

        public static void SetQuestionToFile(string fileName)
        {
            Console.WriteLine("Введите через знак & текст вопрос и цифру с правильным ответом");
            while (true)
            {
                try
                {
                    var stringForQuestion = Console.ReadLine().Split('&');
                    var id = Guid.NewGuid().ToString().Remove(6);
                    var newQuestion = new Question(id, stringForQuestion[0], Convert.ToInt32(stringForQuestion[1]));
                    string _newQuestion = $"question#@{newQuestion.Id}@{newQuestion.Text}@{newQuestion.Answer}";
                    DataFileProvider.Append(fileName, _newQuestion);
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + " Неверный формат вопроса");
                }
            }
        }

        public static void RemoveQuestionFromFile(string fileName, string id)
        {
            var value = DataFileProvider.GetValue(fileName).Split('\n').ToList();
            var lines = value.Where(line => (line != "" && line.Split('@')[1] != id)).Select(line => line).ToArray();
            DataFileProvider.Append(fileName, lines, false);
        }
    }
}


