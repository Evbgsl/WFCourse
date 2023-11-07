﻿namespace GeniyIdiotWinFormApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            начатьЗановоToolStripMenuItem = new ToolStripMenuItem();
            показатьВопросыToolStripMenuItem = new ToolStripMenuItem();
            показатьРезульToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            addNewUserButton = new Button();
            newUserTextBox = new TextBox();
            label1 = new Label();
            resultPanel = new Panel();
            resultDataGridView = new DataGridView();
            userName = new DataGridViewTextBoxColumn();
            Percent = new DataGridViewTextBoxColumn();
            userDiagnose = new DataGridViewTextBoxColumn();
            questionsDataGridView = new DataGridView();
            IdQuestion = new DataGridViewTextBoxColumn();
            Queistion = new DataGridViewTextBoxColumn();
            Answer = new DataGridViewTextBoxColumn();
            deleteQuestionLabel = new Label();
            DeleteQuestionButton = new Button();
            menuStrip1.SuspendLayout();
            resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nextButton.Location = new Point(18, 208);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(119, 92);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее...";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new Point(18, 65);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(70, 15);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(18, 93);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(85, 15);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(18, 129);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(119, 23);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(1039, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { начатьЗановоToolStripMenuItem, показатьВопросыToolStripMenuItem, показатьРезульToolStripMenuItem, выходToolStripMenuItem, оПрограммеToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(50, 22);
            toolStripMenuItem1.Text = "Menu";
            // 
            // начатьЗановоToolStripMenuItem
            // 
            начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            начатьЗановоToolStripMenuItem.Size = new Size(189, 22);
            начатьЗановоToolStripMenuItem.Text = "Начать заново";
            начатьЗановоToolStripMenuItem.Click += начатьЗановоToolStripMenuItem_Click;
            // 
            // показатьВопросыToolStripMenuItem
            // 
            показатьВопросыToolStripMenuItem.Name = "показатьВопросыToolStripMenuItem";
            показатьВопросыToolStripMenuItem.Size = new Size(189, 22);
            показатьВопросыToolStripMenuItem.Text = "Показать вопросы";
            показатьВопросыToolStripMenuItem.Click += показатьВопросыToolStripMenuItem_Click;
            // 
            // показатьРезульToolStripMenuItem
            // 
            показатьРезульToolStripMenuItem.Name = "показатьРезульToolStripMenuItem";
            показатьРезульToolStripMenuItem.Size = new Size(189, 22);
            показатьРезульToolStripMenuItem.Text = "Показать результаты";
            показатьРезульToolStripMenuItem.Click += показатьРезульToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(189, 22);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(189, 22);
            оПрограммеToolStripMenuItem.Text = "О программе...";
            оПрограммеToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // addNewUserButton
            // 
            addNewUserButton.Location = new Point(359, 41);
            addNewUserButton.Margin = new Padding(2);
            addNewUserButton.Name = "addNewUserButton";
            addNewUserButton.Size = new Size(78, 23);
            addNewUserButton.TabIndex = 6;
            addNewUserButton.Text = "Добавить";
            addNewUserButton.UseVisualStyleBackColor = true;
            addNewUserButton.Click += addNewUserButton_Click;
            // 
            // newUserTextBox
            // 
            newUserTextBox.Location = new Point(152, 42);
            newUserTextBox.Margin = new Padding(2);
            newUserTextBox.Name = "newUserTextBox";
            newUserTextBox.Size = new Size(191, 23);
            newUserTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 7;
            label1.Text = "Новый пользователь";
            // 
            // resultPanel
            // 
            resultPanel.Controls.Add(resultDataGridView);
            resultPanel.Location = new Point(385, 160);
            resultPanel.Margin = new Padding(2);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new Size(586, 271);
            resultPanel.TabIndex = 8;
            resultPanel.Visible = false;
            // 
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { userName, Percent, userDiagnose });
            resultDataGridView.Location = new Point(22, 2);
            resultDataGridView.Margin = new Padding(2);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowHeadersWidth = 62;
            resultDataGridView.RowTemplate.Height = 33;
            resultDataGridView.Size = new Size(392, 140);
            resultDataGridView.TabIndex = 0;
            resultDataGridView.Visible = false;
            // 
            // userName
            // 
            userName.HeaderText = "Пользователь";
            userName.MinimumWidth = 8;
            userName.Name = "userName";
            userName.Width = 150;
            // 
            // Percent
            // 
            Percent.HeaderText = "Кол верных";
            Percent.MinimumWidth = 8;
            Percent.Name = "Percent";
            Percent.Width = 150;
            // 
            // userDiagnose
            // 
            userDiagnose.HeaderText = "Диагноз";
            userDiagnose.MinimumWidth = 8;
            userDiagnose.Name = "userDiagnose";
            userDiagnose.Width = 150;
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdQuestion, Queistion, Answer });
            questionsDataGridView.Location = new Point(385, 160);
            questionsDataGridView.Margin = new Padding(2);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 62;
            questionsDataGridView.RowTemplate.Height = 33;
            questionsDataGridView.Size = new Size(582, 267);
            questionsDataGridView.TabIndex = 1;
            questionsDataGridView.Visible = false;
            // 
            // IdQuestion
            // 
            IdQuestion.HeaderText = "ID вопроса";
            IdQuestion.MinimumWidth = 8;
            IdQuestion.Name = "IdQuestion";
            IdQuestion.Width = 150;
            // 
            // Queistion
            // 
            Queistion.HeaderText = "Вопрос";
            Queistion.MinimumWidth = 8;
            Queistion.Name = "Queistion";
            Queistion.Width = 150;
            // 
            // Answer
            // 
            Answer.HeaderText = "Ответ";
            Answer.MinimumWidth = 8;
            Answer.Name = "Answer";
            Answer.Width = 150;
            // 
            // deleteQuestionLabel
            // 
            deleteQuestionLabel.AutoSize = true;
            deleteQuestionLabel.Location = new Point(438, 127);
            deleteQuestionLabel.Margin = new Padding(2, 0, 2, 0);
            deleteQuestionLabel.Name = "deleteQuestionLabel";
            deleteQuestionLabel.Size = new Size(310, 15);
            deleteQuestionLabel.TabIndex = 9;
            deleteQuestionLabel.Text = "Выделите строку с вопросом, который нужно удалить!";
            deleteQuestionLabel.Visible = false;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.Enabled = false;
            DeleteQuestionButton.Location = new Point(869, 120);
            DeleteQuestionButton.Margin = new Padding(2);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(98, 28);
            DeleteQuestionButton.TabIndex = 10;
            DeleteQuestionButton.Text = "Удалить";
            DeleteQuestionButton.UseVisualStyleBackColor = true;
            DeleteQuestionButton.Visible = false;
            DeleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 581);
            Controls.Add(questionsDataGridView);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(deleteQuestionLabel);
            Controls.Add(resultPanel);
            Controls.Add(label1);
            Controls.Add(addNewUserButton);
            Controls.Add(newUserTextBox);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений - идиот";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            resultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem показатьРезульToolStripMenuItem;
        private Button addNewUserButton;
        private TextBox newUserTextBox;
        private Label label1;
        private ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private Panel resultPanel;
        private DataGridView resultDataGridView;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn Percent;
        private DataGridViewTextBoxColumn userDiagnose;
        private ToolStripMenuItem показатьВопросыToolStripMenuItem;
        private DataGridView questionsDataGridView;
        private DataGridViewTextBoxColumn IdQuestion;
        private DataGridViewTextBoxColumn Queistion;
        private DataGridViewTextBoxColumn Answer;
        private Label deleteQuestionLabel;
        private Button DeleteQuestionButton;
    }
}