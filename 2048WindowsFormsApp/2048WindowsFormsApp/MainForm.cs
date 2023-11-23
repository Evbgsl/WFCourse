using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048WindowsFormsApp
{
    public partial class MainForm : Form
    {
        private const int mapSize = 4;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score;
        private int numberedLabelsCounter;
        private Form resultsForm;
        
        public MainForm()
        {
            InitializeComponent();
        }

        


        private void MainForm_Load(object sender, EventArgs e)
        {
            var helloForm = new HelloForm();
            resultsForm = new ResultsForm();


            helloForm.ShowDialog();
            var userName = helloForm.userNameTextBox.Text;
            var user = new User(userName, 0);

            

            InitMap();
            GenerateNumber();
            ShowScore();
        }


        private void ShowScore()
        {
            ScoreLabel.Text = score.ToString(); 
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add((Control)newLabel);
                    labelsMap[i,j] = (Label)newLabel;
                }
            }
        }

        private object CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 10 + indexColumn *  76;
            int y = 70 + indexRow * 76;
            label.Location = new Point(x, y);
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) 
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize-1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        labelsMap[i,j].Text = (number*2).ToString();
                                        labelsMap[i,k].Text = string.Empty;                                   
                                    }
                                    break;
                                                                
                                }
                            
                            }
                        
                        }
                    
                    }
                }

                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }

                            }

                        }

                    }
                }

            }

            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        labelsMap[i, j].Text = (number * 2).ToString();
                                        labelsMap[i, k].Text = string.Empty;
                                    }
                                    break;

                                }

                            }

                        }

                    }
                }

                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text;
                                    labelsMap[i, k].Text = string.Empty;
                                    break;
                                }
                            }
                        }
                    }
                }

            }

            if (e.KeyCode == Keys.Up)
            {
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        for (int i = 0; i < mapSize; i++)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {
                                for (int k = i + 1; k < mapSize; k++)
                                {
                                    if (labelsMap[k, j].Text != string.Empty)
                                    {
                                        if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                        {
                                            var number = int.Parse(labelsMap[i, j].Text);
                                            score += number * 2;
                                            labelsMap[i, j].Text = (number * 2).ToString();
                                            labelsMap[k, j].Text = string.Empty;
                                        }
                                        break;

                                    }

                                }

                            }

                        }
                    }

                    for (int j = 0; j < mapSize; j++)
                    {
                        for (int i = 0; i < mapSize; i++)
                        {
                            if (labelsMap[i, j].Text == string.Empty)
                            {
                                for (int k = i + 1; k < mapSize; k++)
                                {
                                    if (labelsMap[k, j].Text != string.Empty)
                                    {
                                        labelsMap[i, j].Text = labelsMap[k, j].Text;
                                        labelsMap[k, j].Text = string.Empty;
                                        break;

                                    }

                                }

                            }

                        }
                    }

                }


            }

            if (e.KeyCode == Keys.Down)
            {
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        for (int i = mapSize - 1; i >= 0; i--)
                        {
                            if (labelsMap[i, j].Text != string.Empty)
                            {
                                for (int k = i - 1; k >= 0; k--)
                                {
                                    if (labelsMap[k, j].Text != string.Empty)
                                    {
                                        if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                        {
                                            var number = int.Parse(labelsMap[i, j].Text);
                                            score += number * 2;
                                            labelsMap[i, j].Text = (number * 2).ToString();
                                            labelsMap[k, j].Text = string.Empty;
                                        }
                                        break;

                                    }

                                }

                            }

                        }
                    }

                    for (int j = 0; j < mapSize; j++)
                    {
                        for (int i = mapSize - 1; i >= 0; i--)
                        {
                            if (labelsMap[i, j].Text == string.Empty)
                            {
                                for (int k = i - 1; k >= 0; k--)
                                {
                                    if (labelsMap[k, j].Text != string.Empty)
                                    {
                                        labelsMap[i, j].Text = labelsMap[k, j].Text;
                                        labelsMap[k, j].Text = string.Empty;
                                        break;

                                    }

                                }

                            }

                        }
                    }

                }

            }

            GenerateNumber();

            ShowScore();
        }

        //Работа основного меню
        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rulesOfGame2048 = @"rulesOfGame2048.json";
            if (!File.Exists(rulesOfGame2048))
            {
                MessageBox.Show("Сегодня правила не завезли, разбирайтесь сами", "2048");
            }
            else 
            {
                var rulesForm = new Form();
                rulesForm.Size = new Size(640, 480);
                rulesForm.StartPosition = FormStartPosition.CenterScreen;
                rulesForm.Text = "2048";

                var rulesTextBox = new RichTextBox();
                rulesTextBox.Dock = DockStyle.Fill;

                rulesForm.Controls.Add(rulesTextBox);

                var value = DataFileProvider.GetValue(rulesOfGame2048);
                rulesTextBox.Text = value;

                rulesForm.ShowDialog();
            }

        }

        //Helpers
        private void GenerateNumber()
        {
            while (true && CheckEmptyLabels())
            {
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;

                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    labelsMap[indexRow, indexColumn].Text = GenererateRandom2_4().ToString();
                    numberedLabelsCounter++;
                    break;
                }
            }
        }

        private int GenererateRandom2_4()
        {
            int[] A = new int[] { 2, 2, 2, 4 };
            Random rand = new Random();
            int index = rand.Next(0, A.Length);
            int result = A[index];
            return result;
        }

        private bool CheckEmptyLabels()
        {
            var flag = false;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        flag = true;
                        break;
                    }
                }
            }

            if (!flag)
            {
                MessageBox.Show("Игра закончена", "2048");            
            }
            return flag;
        }

        private void показатьРекордыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultsDataFilePath = @"results.json";
            DataFileProvider.CheckResultFile(resultsDataFilePath);

            var value = DataFileProvider.GetValue(resultsDataFilePath);
            var results = JsonConvert.DeserializeObject<List<User>>(value);

            resultsForm.Show();

            //resultsForm.??? //нет доступа к DataGrid

   

            //foreach ( var item in results ) 
            //{
                
                
            
            //}

        }
    }
}
