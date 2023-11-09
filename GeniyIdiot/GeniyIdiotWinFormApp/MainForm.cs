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
        private string user;
        private string value;
        private string fileName;

        private string questionsDataFilePath;
        private string resultsDataFilePath;

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
            user = "����������";
            var helloForm = new HelloForm();
            helloForm.ShowDialog();
            user = helloForm.userNameTextBox.Text;

            fileName = @"datafile.txt";
            questionsDataFilePath = @"questionsDataFile.json";
            resultsDataFilePath = @"resultsDataFile.json";

            if (!File.Exists(questionsDataFilePath))
            {
                questions = new List<Question>();
                questions.Add(new Question("skddk", "��� ���� ��� �������� �� ���", 6));
                questions.Add(new Question("skdd1", "������� ����� ��������, ����� ��������� ������ �� 10 ������?", 9));
                questions.Add(new Question("skd123", "�� ���� ����� 10 �������. ������� ������� �� 5 �����?", 25));
                questions.Add(new Question("skddk554", "���� ������ 1 ��� � 30 �����. ������� ����� ��� �� 3 �����?", 60));


                var _newQuestions = JsonConvert.SerializeObject(questions);
                DataFileProvider.Replace(questionsDataFilePath, _newQuestions, false);                
            }

            value = DataFileProvider.GetValue(questionsDataFilePath);
            questions = JsonConvert.DeserializeObject<List<Question>>(value);


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
            resultDataGridView.Rows.Clear();

            var results = UserStorage.GetResultsFromFile(fileName);
            foreach (var result in results)
            {
                resultDataGridView.Rows.Add(result[1], result[2], result[3]);
            }
            resultPanel.Visible = true;
            questionsDataGridView.Visible = false;
            resultDataGridView.Visible = true;
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
            QuestionsStorage.GetQuestionsFromDataFile(questionsDataFilePath, questionsDataGridView);


            DeleteQuestionButton.Visible = true;
            deleteQuestionLabel.Visible = true;
            resultPanel.Visible = true;
            questionsDataGridView.Visible = true;

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
                        QuestionsStorage.RemoveQuestionFromFile(questionsDataFilePath, valueInFirstColumn);
                        MessageBox.Show("������ ������!", "����� - �����");
                        row.Visible = false;

                    }
                }
            }

        }

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show("�������� ������!", "����� - �����");
                    QuestionsStorage.GetQuestionsFromDataFile(questionsDataFilePath, questionsDataGridView);

                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " �������� ������ �������");
                }
            }
        }
    }
}