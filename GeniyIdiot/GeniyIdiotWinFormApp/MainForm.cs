using System.Net.WebSockets;
using GeniyIdiot.Common;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace GeniyIdiotWinFormApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private string user;
        private string value;
        private string fileName;
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



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fileName = @"datafile.txt";
            //user = new User("неизвестно");
            value = DataFileProvider.GetValue(fileName);
            questions = QuestionsStorage.GetQuestions(value);
            countQuestions = questions.Count;


            questionNumberLabel.Text = $"Вопрос номер 1";
            ShowNextQuestion();

        }

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

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("Введите имя пользователя", "Гений - идиот");
                return;
            }



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
                        DataFileProvider.Append(fileName, $"result#{user}#{userDiagnose}");
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

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Супер тест 2023", "Гений - идиот");
            return;

        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            user = newUserTextBox.Text;
            newUserTextBox.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();

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
            resultPanel.Visible = true;
            MessageBox.Show("Хорошие результаты", "Гений - идиот");
        }
    }
}