using System.Collections.Generic;
using System.Linq;
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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


        public static void GetQuestionsFromDataFile(string questionsDataFilePath, DataGridView questionsDataGridView)
        {
            
            questionsDataGridView.Rows.Clear();
            var value = DataFileProvider.GetValue(questionsDataFilePath);
            var questions = JsonConvert.DeserializeObject<List<Question>>(value);
            foreach (var question in questions)
            {
                questionsDataGridView.Rows.Add(question.Id, question.Text, question.Answer);
            }
        }

        public static void RemoveQuestionFromFile(string questionsDataFilePath, string id)
        {
            var value = DataFileProvider.GetValue(questionsDataFilePath);
            var questions = JsonConvert.DeserializeObject<List<Question>>(value);
            var _questions = JsonConvert.SerializeObject(questions.Where(question => question.Id != id));
            DataFileProvider.Replace(questionsDataFilePath, _questions, false);
        }
    }
}


