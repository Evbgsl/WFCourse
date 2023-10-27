using System.Net.WebSockets;
using GeniyIdiot.Common;

namespace GeniyIdiotWinFormApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private User user;
        private string value;
        private string fileName;
        private int rightAnswer;
        private int countRightAnswers;

        public MainForm()
        {
            InitializeComponent();
        }

        private void userAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fileName = @"datafile.txt";
            user = new User("неизвестно");
            value = DataFileProvider.GetValue(fileName);
            questions = QuestionsStorage.GetQuestions(value);
            ShowNextQuestion();

        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            var countQuestions = questions.Count;
            var randomIndex = random.Next(countQuestions);
            questionTextLabel.Text = questions[randomIndex].Text;
            rightAnswer = questions[randomIndex].Answer;
            questions.RemoveAt(randomIndex);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            if (userAnswer == rightAnswer)
            {
                countRightAnswers++;
            }
            var endTest = questions.Count == 0;
            if (endTest) 
            {
                MessageBox.Show("Тест окончен", "Гений - идиот");
                return; 
            }
            ShowNextQuestion();

        }
    }
}