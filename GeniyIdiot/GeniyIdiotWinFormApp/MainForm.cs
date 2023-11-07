using System.Net.WebSockets;
using System.Windows.Forms;
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
            countQuestions = questions.Count;
            questionNumberLabel.Text = $"������ ����� 1";
            ShowNextQuestion();

        }

        private void ShowNextQuestion()
        {
            userAnswerTextBox.Text = null;
            questionNumber++;
            questionNumberLabel.Text = $"������ ����� {questionNumber}";

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
                MessageBox.Show("������� ��� ������������", "����� - �����");
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
                        DataFileProvider.Append(fileName, $"result#@{user}@{percentOfRightAnswers}@{userDiagnose}");
                        MessageBox.Show($"���� �������. ���������� ���������� ������� {countQuestions}. ��� ������� - {userDiagnose}", "����� - �����");

                        return;
                    }
                    ShowNextQuestion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void ������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var results = UserStorage.GetResultsFromFile(fileName);
            foreach (var result in results)
            {
                resultDataGridView.Rows.Add(result[1], result[2], result[3]);
            }
            resultPanel.Visible = true;
            resultDataGridView.Visible = true;
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            questions = QuestionsStorage.GetQuestions(value);
            foreach (var question in questions)
            {
                questionsDataGridView.Rows.Add(question.Id, question.Text, question.Answer);
            }
            deleteQuestionLabel.Visible = true;
            resultPanel.Visible = true;
            questionsDataGridView.Visible = true;
            DeleteQuestionButton.Visible = true;

            questionsDataGridView.SelectionChanged += QuestionsDataGridView_SelectionChanged;

        }

        private void QuestionsDataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (questionsDataGridView.SelectedRows.Count > 0)
            {
                DeleteQuestionButton.Enabled = true;
            }
        }

        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {

            if (questionsDataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in questionsDataGridView.SelectedRows)
                {
                    string valueInFirstColumn = row.Cells[0].Value?.ToString(); // �������� �������� �� ������ ������� ������� ������
                    if (!string.IsNullOrEmpty(valueInFirstColumn))
                    {
                        QuestionsStorage.RemoveQuestionFromFile(fileName, valueInFirstColumn);
                        MessageBox.Show("������ ������!", "����� - �����");
                        row.Visible = false;

                    }
                }
            }

        }
    }
}