using System.Net.WebSockets;
using GeniyIdiot.Common;
using static System.Net.Mime.MediaTypeNames;

namespace GeniyIdiotWinFormApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        string user;
        private string value;
        private string fileName;
        private int rightAnswer;
        private int countRightAnswers;
        private int countQuestions;
        private List<Diagnose> diagnoses = new List<Diagnose>
                                                {
                                                    new Diagnose("�����"),
                                                    new Diagnose("������"),
                                                    new Diagnose("�����"),
                                                    new Diagnose("����������"),
                                                    new Diagnose("������"),
                                                    new Diagnose("�����")
                                                };



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fileName = @"datafile.txt";
            //user = new User("����������");
            value = DataFileProvider.GetValue(fileName);
            questions = QuestionsStorage.GetQuestions(value);
            ShowNextQuestion();

        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            countQuestions = questions.Count;
            var randomIndex = random.Next(countQuestions);
            questionTextLabel.Text = questions[randomIndex].Text;
            rightAnswer = questions[randomIndex].Answer;
            questions.RemoveAt(randomIndex);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                MessageBox.Show("������� ��� ������������", "����� - �����");
                return;
            }    
                

            int userAnswer;
            {
                try
                {
                    userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
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
                        MessageBox.Show($"���� �������. ���������� ���������� ������� {countQuestions}. ��� ������� - {userDiagnose}", "����� - �����");

                        return;
                    }
                    ShowNextQuestion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("������������ ������ �����", "����� - �����");
                    return;
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ���� 2023", "����� - �����");
            return;

        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            user = newUserTextBox.Text;
            newUserTextBox.Enabled = false;

        }
    }
}