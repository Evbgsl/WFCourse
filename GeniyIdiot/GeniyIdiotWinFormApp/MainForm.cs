using System.Net.WebSockets;
using System.Windows.Forms;
using GeniyIdiot.Common;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using Application = System.Windows.Forms.Application;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace GeniyIdiotWinFormApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private User user;
        private string value;
        private string fileName;

        public string questionsDataFilePath;
        public string resultsDataFilePath;

        private QuestionsForm questionsForm;

        private int rightAnswer;
        private int countRightAnswers;
        private int countQuestions;
        private int questionNumber;
        private List<Diagnose> diagnoses = new List<Diagnose>
                                                {
                                                    new Diagnose("Идиот"),
                                                    new Diagnose("Кретин"),
                                                    new Diagnose("Дурак"),
                                                    new Diagnose("Нормальный"),
                                                    new Diagnose("Талант"),
                                                    new Diagnose("Гений")
                                                };



        //Основная логика

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var helloForm = new HelloForm();
            questionsForm = new QuestionsForm();




            helloForm.ShowDialog();
            user = new User(helloForm.userNameTextBox.Text, "", 0);

            fileName = @"datafile.txt";
            questionsDataFilePath = @"questionsDataFile.json";
            resultsDataFilePath = @"resultsDataFile.json";

            if (!File.Exists(questionsDataFilePath))
            {
                questions = new List<Question>();
                questions.Add(new Question("skddk", "Два плюс два умножить на два", 6));
                questions.Add(new Question("skdd1", "Сколько нужно распилов, чтобы разделить бревно на 10 частей?", 9));
                questions.Add(new Question("skd123", "На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("skddk554", "Укол делают 1 раз в 30 минут. Сколько нужно мин на 3 укола?", 60));


                var _newQuestions = JsonConvert.SerializeObject(questions);
                DataFileProvider.Replace(questionsDataFilePath, _newQuestions, false);
            }

            value = DataFileProvider.GetValue(questionsDataFilePath);
            questions = JsonConvert.DeserializeObject<List<Question>>(value);

            countQuestions = questions.Count;
            questionNumberLabel.Text = $"Вопрос номер 1";
            ShowNextQuestion();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
                    if (userAnswer == rightAnswer)
                    {
                        countRightAnswers++;
                    }
                    var endTest = questions.Count == 0;
                    if (endTest)
                    {

                        var percentOfRightAnswers = 100 * countRightAnswers / countQuestions;
                        var userDiagnose = DiagnoseStorage.GetDiagnose(diagnoses, percentOfRightAnswers);


                        user.Diagnose = userDiagnose;
                        user.PercentOfRightAnswers = percentOfRightAnswers;
                        var usersResults = new List<User>();

                        if (!File.Exists(resultsDataFilePath))
                        {
                            usersResults = new List<User>();
                        }
                        else
                        {
                            value = DataFileProvider.GetValue(resultsDataFilePath);
                            usersResults = JsonConvert.DeserializeObject<List<User>>(value);

                        }

                        usersResults.Add(user);

                        var _userResults = JsonConvert.SerializeObject(usersResults);
                        DataFileProvider.Replace(resultsDataFilePath, _userResults, false);

                        MessageBox.Show($"Тест окончен. Количество правильных ответов {countQuestions}. Ваш диагноз - {userDiagnose}", "Гений - идиот");

                        return;
                    }
                    ShowNextQuestion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    MessageBox.Show("Некорректный формат числа", "Гений - идиот");
                    return;
                }
            }
        }



        //Работа с вопросами
        private void ShowNextQuestion()
        {
            userAnswerTextBox.Text = null;
            questionNumber++;
            questionNumberLabel.Text = $"Вопрос номер {questionNumber}";

            var random = new Random();
            var _countQuestions = questions.Count;
            var randomIndex = random.Next(_countQuestions);
            questionTextLabel.Text = questions[randomIndex].Text;
            rightAnswer = questions[randomIndex].Answer;
            questions.RemoveAt(randomIndex);
        }

        private void показатьВопросыToolStripMenuItem_Click(object sender, EventArgs e)
        {


            QuestionsStorage.GetQuestionsFromDataFile(questionsDataFilePath, questionsForm.questionsDataGridView);
            questionsForm.Show();

            questionsForm.questionsDataGridViewSelectionChanged += QuestionsDataGridView_SelectionChanged;
            questionsForm.DeleteQuestionButtonClickEvent += QuestionsForm_DeleteQuestionButtonClickEvent;

        }

        private void QuestionsForm_DeleteQuestionButtonClickEvent(object? sender, EventArgs e)
        {
            if (questionsForm.questionsDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in questionsForm.questionsDataGridView.SelectedRows)
                {
                    string valueInFirstColumn = row.Cells[0].Value?.ToString(); // Получаем значение из первой колонки текущей строки
                    if (!string.IsNullOrEmpty(valueInFirstColumn))
                    {
                        QuestionsStorage.RemoveQuestionFromFile(questionsDataFilePath, valueInFirstColumn);
                        MessageBox.Show("Вопрос удален!", "Гений - идиот");
                        row.Visible = false;
                        questionsForm.DeleteQuestionButton.Enabled = false;

                    }
                }
            }
        }

        private void QuestionsDataGridView_SelectionChanged(object? sender, EventArgs e)
        {

            if (questionsForm.questionsDataGridView.SelectedRows.Count > 0)
            {
                questionsForm.DeleteQuestionButton.Enabled = true;
            }
        }

        //private void DeleteQuestionButton_Click(object sender, EventArgs e)
        //{

        //    if (questionsForm.questionsDataGridView.SelectedRows.Count > 0)
        //    {
        //        foreach (DataGridViewRow row in questionsForm.questionsDataGridView.SelectedRows)
        //        {
        //            string valueInFirstColumn = row.Cells[0].Value?.ToString(); // Получаем значение из первой колонки текущей строки
        //            if (!string.IsNullOrEmpty(valueInFirstColumn))
        //            {
        //                QuestionsStorage.RemoveQuestionFromFile(questionsDataFilePath, valueInFirstColumn);
        //                MessageBox.Show("Вопрос удален!", "Гений - идиот");
        //                row.Visible = false;

        //            }
        //        }
        //    }

        //}

        private void добавитьВопросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //questionsForm.Show();

            addQuestionButton.Visible = true;
            answerTextBox.Visible = true;
            questionTextBox.Visible = true;
            addQuestionLabel.Visible = true;
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(answerTextBox.Text) && !string.IsNullOrEmpty(questionTextBox.Text))
            {

                try
                {
                    var id = Guid.NewGuid().ToString().Remove(6);
                    var stringForQuestion = questionTextBox.Text;
                    var answerForQuestion = Convert.ToInt32(answerTextBox.Text);
                    var newQuestion = new Question(id, stringForQuestion, answerForQuestion);

                    value = DataFileProvider.GetValue(questionsDataFilePath);
                    questions = JsonConvert.DeserializeObject<List<Question>>(value);
                    questions.Add(newQuestion);

                    var _newQuestions = JsonConvert.SerializeObject(questions);

                    DataFileProvider.Replace(questionsDataFilePath, _newQuestions, false);
                    MessageBox.Show("Добавлен вопрос!", "Гений - идиот");
                    QuestionsStorage.GetQuestionsFromDataFile(questionsDataFilePath, questionsForm.questionsDataGridView);

                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " Неверный формат вопроса");
                }
            }
        }


        //Работа с результатами 

        private void ShowResults()
        {
            resultDataGridView.Rows.Clear();

            value = DataFileProvider.GetValue(resultsDataFilePath);
            var users = JsonConvert.DeserializeObject<List<User>>(value);

            foreach (var user in users)
            {
                resultDataGridView.Rows.Add(user.Name, user.PercentOfRightAnswers, user.Diagnose);
            }
            resultPanel.Visible = true;
            
            resultDataGridView.Visible = true;
        }


        //Работа с меню
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Супер тест 2023", "Гений - идиот");
            return;

        }

        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void показатьРезульToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowResults();
        }

        private void deleteQuestionLabel_Click(object sender, EventArgs e)
        {

        }
    }

}