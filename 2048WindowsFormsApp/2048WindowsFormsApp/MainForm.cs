﻿using _2048WindowsFormsApp.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
        private int mapSize;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private User user;
        private int score;
        private int numberedLabelsCounter;
        public string resultsDataFilePath = @"results.json";
        public ResultsForm resultsForm;
        
        public MainForm()
        {
            InitializeComponent();
        }

        //Основная логика программы
        private void MainForm_Load(object sender, EventArgs e)
        {
            var helloForm = new HelloForm();
            resultsForm = new ResultsForm();

            helloForm.ShowDialog();
            var userName = helloForm.userNameTextBox.Text;
            user = new User(userName, 0);

            mapSize = Settings.Default.MapSizeSet;

            var mainFormWidth = mapSize * (70 + 6) + 30;
            var mainFormHeith = mapSize * (70 + 6) + 115;
            Size = new Size(mainFormWidth, mainFormHeith);

            InitMap();
            GenerateNumber();
            ShowScore();
        }
        private void ShowScore()
        {
            ScoreLabel.Text = score.ToString(); 
            if (score > Settings.Default.BestScore) 
            {
                Settings.Default.BestScore = score;
                Settings.Default.Save();
            }
            BestScoreLabel.Text = Settings.Default.BestScore.ToString();
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
            #region Обработка нажатия стрелок
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
            #endregion

            GenerateNumber();

            ShowScore();

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    ChangeLabelColor(labelsMap[i, j]);
                }
            }

        }

        private void ChangeLabelColor(Label label)
        {
            if (label.Text == string.Empty)
            {
                label.BackColor = Color.FromArgb(255, 255, 0); 
                return;
            }
            var exponentOfTwo = WhatPowerOfTwo(Convert.ToInt32(label.Text));
            label.BackColor = Color.FromArgb(255-exponentOfTwo*20, 255 - exponentOfTwo*20, 0);
        }
        //Работа основного меню
        private void начатьЗановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
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
        private void показатьРекордыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resultsForm.resultsGridView.Rows.Clear();

            if (!File.Exists(resultsDataFilePath))
            {
                MessageBox.Show("Предыдущих результатов нет");
            }
            else
            {
                var value = DataFileProvider.GetValue(resultsDataFilePath);
                var results = JsonConvert.DeserializeObject<List<User>>(value);
                foreach (var item in results)
                {
                    resultsForm.resultsGridView.Rows.Add(item.Name, item.Result);
                }
                resultsForm.Show();
            }


        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void изменитьРазмерПоляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mapSizeInputDialog = new MapSizeInputDialog();
            mapSizeInputDialog.ShowDialog();
            Settings.Default.MapSizeSet = Convert.ToInt32(mapSizeInputDialog.mapSizeTextBox.Text);
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
                SaveGameResults();
                MessageBox.Show("Игра закончена", "2048");            
            }
            return flag;
        }
        private void SaveGameResults()
        {
            var _usersResults = new List<User>();

            if (File.Exists(resultsDataFilePath))
            {     
                var value = DataFileProvider.GetValue(resultsDataFilePath);
                _usersResults = JsonConvert.DeserializeObject<List<User>>(value);
            }

            user.Result = score;
            _usersResults.Add(user);

            var _userResults = JsonConvert.SerializeObject(_usersResults);
            DataFileProvider.Replace(resultsDataFilePath, _userResults, false);
        }
        private int WhatPowerOfTwo(int number)
        {
            // Check if the number is a power of two
            if (number <= 0 || (number & (number - 1)) != 0)
            {
                // If the number is not a power of two, return a special value (e.g., -1) to indicate that
                return -1;
            }

            int exponent = 0;
            while ((number & 1) == 0)
            {
                number >>= 1;
                exponent++;
            }

            return exponent;
        }


    }
}
