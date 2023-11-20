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
        private ResultsForm resultsForm;

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


        //�������� ������
        //test
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var helloForm = new HelloForm();
            questionsForm = new QuestionsForm();
            resultsForm = new ResultsForm();

            helloForm.ShowDialog();
            user = new User(helloForm.userNameTextBox.Text, "", 0);
            userAnswerTextBox.Focus();

            fileName = @"datafile.txt";
            questionsDataFilePath = @"questionsDataFile.json";
            resultsDataFilePath = @"resultsDataFile.json";

            if (!File.Exists(questionsDataFilePath))
            {
                NewQuestionsWriter();
                var _newQuestions = JsonConvert.SerializeObject(questions);
                DataFileProvider.Replace(questionsDataFilePath, _newQuestions, false);
            }

            value = DataFileProvider.GetValue(questionsDataFilePath);
            questions = JsonConvert.DeserializeObject<List<Question>>(value);

            countQuestions = questions.Count;

            if (countQuestions == 0)
            {
                NewQuestionsWriter();
                countQuestions = questions.Count;
                MessageBox.Show($"������ �������� ��� ����, ��������� ������� �������.", "����� - �����");
                var _baseQuestions = JsonConvert.SerializeObject(questions);
                DataFileProvider.Replace(questionsDataFilePath, _baseQuestions, false);
            }

            questionNumberLabel.Text = $"������ ����� 1";

            timer1.Tick += timer1_Tick;

            ShowNextQuestion();
        }

        private void userAnswerTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NextStep();
            }
        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            NextStep();
        }

        private void NextStep()
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
                    EndTest();
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

        private void EndTest()
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

            timer1.Stop();
            timer1.Enabled = false;
            progressBar1.Visible = false;

            ShowResultEndTest(userDiagnose);

            return;
        }

        private void ShowResultEndTest(string userDiagnose)
        {
            resultPanel.Visible = true;
            diagnoseLabel.Text = $"���� �������. ���������� ���������� ������� {countRightAnswers}. ��� ������� - {userDiagnose}";
            finishLabel.Text = $"{user.Name}, �� - {userDiagnose.ToLower()}, ���� ��������, ����� ������!";
        }


        //������ � ���������
        private void NewQuestionsWriter()
        {
            questions = new List<Question>
            {
                new Question("aa1234", "��� ���� ��� �������� �� ���", 6),
                new Question("ab1234", "������� ����� ��������, ����� ��������� ������ �� 10 ������?", 9),
                new Question("ac1234", "�� ���� ����� 10 �������. ������� ������� �� 5 �����?", 25),
                new Question("ad1234", "���� ������ 1 ��� � 30 �����. ������� ����� ��� �� 3 �����?", 60),
                new Question("ae1234", "���� ������ ������, ��� �������. ������� ������ ��������?", 2)
            };
        }

        private void ShowNextQuestion()
        {
            progressBar1.Visible = true;
            timer1.Stop();
            timer1.Enabled = false;
            progressBar1.Value = 0;

            timer1.Interval = 1000;
            timer1.Start();
            timer1.Enabled = true;

            userAnswerTextBox.Text = null;
            questionNumber++;
            questionNumberLabel.Text = $"������ ����� {questionNumber}";

            var random = new Random();
            var _countQuestions = questions.Count;

            if (_countQuestions == 0)
            {
                timer1.Stop();
                timer1.Enabled = false;
                EndTest();
                return;
            }
            var randomIndex = random.Next(_countQuestions);
            questionTextLabel.Text = questions[randomIndex].Text;
            rightAnswer = questions[randomIndex].Answer;
            questions.RemoveAt(randomIndex);
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestionsStorage.GetQuestionsFromDataFile(questionsDataFilePath, questionsForm.questionsDataGridView);
            if (questionsForm.questionsDataGridView.Rows.Count < 2)
            {
                MessageBox.Show("������� ���������, ������������� ����", "����� - �����");
                return;
            }
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
                    string valueInFirstColumn = row.Cells[0].Value?.ToString(); // �������� �������� �� ������ ������� ������� ������
                    if (!string.IsNullOrEmpty(valueInFirstColumn))
                    {
                        QuestionsStorage.RemoveQuestionFromFile(questionsDataFilePath, valueInFirstColumn);

                        row.Visible = false;
                        questionsForm.DeleteQuestionButton.Enabled = false;

                    }
                }
                MessageBox.Show("������ ������!", "����� - �����");
            }
        }

        private void QuestionsDataGridView_SelectionChanged(object? sender, EventArgs e)
        {
            if (questionsForm.questionsDataGridView.SelectedRows.Count > 0)
            {
                questionsForm.DeleteQuestionButton.Enabled = true;
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
                    QuestionsStorage.GetQuestionsFromDataFile(questionsDataFilePath, questionsForm.questionsDataGridView);

                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + " �������� ������ �������");
                }
            }
        }


        //������ � ������������ 
        private void ShowResults()
        {
            resultsForm.resultDataGridView.Rows.Clear();

            value = DataFileProvider.GetValue(resultsDataFilePath);
            var users = JsonConvert.DeserializeObject<List<User>>(value);

            foreach (var user in users)
            {
                resultsForm.resultDataGridView.Rows.Add(user.Name, user.PercentOfRightAnswers, user.Diagnose);
            }
            resultsForm.Show();
        }


        //������ � ����
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
            ShowResults();
        }

        //������
        private void timer1_Tick(object? sender, EventArgs e)
        {
            userAnswerTextBox.Focus();
            progressBar1.PerformStep();


            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                timer1.Enabled = false;
                ShowNextQuestion();
            }
        }
    }

}