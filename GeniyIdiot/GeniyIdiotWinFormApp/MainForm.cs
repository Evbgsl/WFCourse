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
                                                    new Diagnose("�����"),
                                                    new Diagnose("������"),
                                                    new Diagnose("�����"),
                                                    new Diagnose("����������"),
                                                    new Diagnose("������"),
                                                    new Diagnose("�����")
                                                };



        //�������� ������

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



        //������ � ���������
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

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
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
                    string valueInFirstColumn = row.Cells[0].Value?.ToString(); // �������� �������� �� ������ ������� ������� ������
                    if (!string.IsNullOrEmpty(valueInFirstColumn))
                    {
                        QuestionsStorage.RemoveQuestionFromFile(questionsDataFilePath, valueInFirstColumn);
                        MessageBox.Show("������ ������!", "����� - �����");
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
        //            string valueInFirstColumn = row.Cells[0].Value?.ToString(); // �������� �������� �� ������ ������� ������� ������
        //            if (!string.IsNullOrEmpty(valueInFirstColumn))
        //            {
        //                QuestionsStorage.RemoveQuestionFromFile(questionsDataFilePath, valueInFirstColumn);
        //                MessageBox.Show("������ ������!", "����� - �����");
        //                row.Visible = false;

        //            }
        //        }
        //    }

        //}

        private void ��������������ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void deleteQuestionLabel_Click(object sender, EventArgs e)
        {

        }
    }

}