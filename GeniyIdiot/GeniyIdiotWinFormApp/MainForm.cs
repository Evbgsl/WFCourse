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
                                                    new Diagnose("Èäèîò"),
                                                    new Diagnose("Êðåòèí"),
                                                    new Diagnose("Äóðàê"),
                                                    new Diagnose("Íîðìàëüíûé"),
                                                    new Diagnose("Òàëàíò"),
                                                    new Diagnose("Ãåíèé")
                                                };



        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            fileName = @"datafile.txt";
            //user = new User("íåèçâåñòíî");
            value = DataFileProvider.GetValue(fileName);
            questions = QuestionsStorage.GetQuestions(value);
            countQuestions = questions.Count;
            
            
            questionNumberLabel.Text = $"Âîïðîñ íîìåð 1";
            ShowNextQuestion();

        }

        private void ShowNextQuestion()
        {
            userAnswerTextBox.Text = null;
            questionNumber++;
            questionNumberLabel.Text = $"Âîïðîñ íîìåð {questionNumber}";

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
                MessageBox.Show("Ââåäèòå èìÿ ïîëüçîâàòåëÿ", "Ãåíèé - èäèîò");
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
                        MessageBox.Show($"Òåñò îêîí÷åí. Êîëè÷åñòâî ïðàâèëüíûõ îòâåòîâ {countQuestions}. Âàø äèàãíîç - {userDiagnose}", "Ãåíèé - èäèîò");

                        return;
                    }
                    ShowNextQuestion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    MessageBox.Show("Íåêîððåêòíûé ôîðìàò ÷èñëà", "Ãåíèé - èäèîò");
                    return;
                }
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ñóïåð òåñò 2023", "Ãåíèé - èäèîò");
            return;

        }

        private void addNewUserButton_Click(object sender, EventArgs e)
        {
            user = newUserTextBox.Text;
            newUserTextBox.Enabled = false;

        }


        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void íà÷àòüÇàíîâîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ïîêàçàòüÐåçóëüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultPanel.Visible = true;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();


        }
    }
}