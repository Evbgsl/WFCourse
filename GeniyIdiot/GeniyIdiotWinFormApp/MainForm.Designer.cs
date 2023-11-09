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
            добавитьВопросToolStripMenuItem = new ToolStripMenuItem();
            resultPanel = new Panel();
            questionsDataGridView = new DataGridView();
            IdQuestion = new DataGridViewTextBoxColumn();
            Queistion = new DataGridViewTextBoxColumn();
            Answer = new DataGridViewTextBoxColumn();
            resultDataGridView = new DataGridView();
            userName = new DataGridViewTextBoxColumn();
            Percent = new DataGridViewTextBoxColumn();
            userDiagnose = new DataGridViewTextBoxColumn();
            addQuestionButton = new Button();
            answerTextBox = new TextBox();
            questionTextBox = new TextBox();
            addQuestionLabel = new Label();
            deleteQuestionLabel = new Label();
            DeleteQuestionButton = new Button();
            menuStrip1.SuspendLayout();
            resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nextButton.Location = new Point(26, 212);
            nextButton.Margin = new Padding(4, 5, 4, 5);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(170, 153);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее...";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Location = new Point(26, 63);
            questionNumberLabel.Margin = new Padding(4, 0, 4, 0);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(108, 25);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(26, 108);
            questionTextLabel.Margin = new Padding(4, 0, 4, 0);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(129, 25);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(26, 138);
            userAnswerTextBox.Margin = new Padding(4, 5, 4, 5);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(168, 31);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1484, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { начатьЗановоToolStripMenuItem, показатьВопросыToolStripMenuItem, показатьРезульToolStripMenuItem, выходToolStripMenuItem, оПрограммеToolStripMenuItem, добавитьВопросToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(73, 29);
            toolStripMenuItem1.Text = "Menu";
            // 
            // начатьЗановоToolStripMenuItem
            // 
            начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            начатьЗановоToolStripMenuItem.Size = new Size(285, 34);
            начатьЗановоToolStripMenuItem.Text = "Начать заново";
            начатьЗановоToolStripMenuItem.Click += начатьЗановоToolStripMenuItem_Click;
            // 
            // показатьВопросыToolStripMenuItem
            // 
            показатьВопросыToolStripMenuItem.Name = "показатьВопросыToolStripMenuItem";
            показатьВопросыToolStripMenuItem.Size = new Size(285, 34);
            показатьВопросыToolStripMenuItem.Text = "Показать вопросы";
            показатьВопросыToolStripMenuItem.Click += показатьВопросыToolStripMenuItem_Click;
            // 
            // показатьРезульToolStripMenuItem
            // 
            показатьРезульToolStripMenuItem.Name = "показатьРезульToolStripMenuItem";
            показатьРезульToolStripMenuItem.Size = new Size(285, 34);
            показатьРезульToolStripMenuItem.Text = "Показать результаты";
            показатьРезульToolStripMenuItem.Click += показатьРезульToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(285, 34);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // оПрограммеToolStripMenuItem
            // 
            оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            оПрограммеToolStripMenuItem.Size = new Size(285, 34);
            оПрограммеToolStripMenuItem.Text = "О программе...";
            оПрограммеToolStripMenuItem.Click += ToolStripMenuItem_Click;
            // 
            // добавитьВопросToolStripMenuItem
            // 
            добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            добавитьВопросToolStripMenuItem.Size = new Size(285, 34);
            добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            добавитьВопросToolStripMenuItem.Click += добавитьВопросToolStripMenuItem_Click;
            // 
            // resultPanel
            // 
            resultPanel.Controls.Add(questionsDataGridView);
            resultPanel.Controls.Add(resultDataGridView);
            resultPanel.Location = new Point(550, 297);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new Size(837, 422);
            resultPanel.TabIndex = 8;
            resultPanel.Visible = false;
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdQuestion, Queistion, Answer });
            questionsDataGridView.Location = new Point(0, 3);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 62;
            questionsDataGridView.RowTemplate.Height = 33;
            questionsDataGridView.Size = new Size(831, 415);
            questionsDataGridView.TabIndex = 1;
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
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { userName, Percent, userDiagnose });
            resultDataGridView.Location = new Point(3, 22);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowHeadersWidth = 62;
            resultDataGridView.RowTemplate.Height = 33;
            resultDataGridView.Size = new Size(810, 380);
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
            // addQuestionButton
            // 
            addQuestionButton.Location = new Point(26, 550);
            addQuestionButton.Margin = new Padding(4, 5, 4, 5);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(186, 38);
            addQuestionButton.TabIndex = 11;
            addQuestionButton.Text = "Добавить вопрос";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Visible = false;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(426, 472);
            answerTextBox.Margin = new Padding(4, 5, 4, 5);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(97, 31);
            answerTextBox.TabIndex = 11;
            answerTextBox.Visible = false;
            // 
            // questionTextBox
            // 
            questionTextBox.Location = new Point(26, 472);
            questionTextBox.Margin = new Padding(4, 5, 4, 5);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(364, 31);
            questionTextBox.TabIndex = 11;
            questionTextBox.Visible = false;
            // 
            // addQuestionLabel
            // 
            addQuestionLabel.AutoSize = true;
            addQuestionLabel.Location = new Point(26, 415);
            addQuestionLabel.Margin = new Padding(4, 0, 4, 0);
            addQuestionLabel.Name = "addQuestionLabel";
            addQuestionLabel.Size = new Size(261, 25);
            addQuestionLabel.TabIndex = 11;
            addQuestionLabel.Text = "Введите текст вопроса и ответ";
            addQuestionLabel.Visible = false;
            // 
            // deleteQuestionLabel
            // 
            deleteQuestionLabel.AutoSize = true;
            deleteQuestionLabel.Location = new Point(626, 212);
            deleteQuestionLabel.Name = "deleteQuestionLabel";
            deleteQuestionLabel.Size = new Size(464, 25);
            deleteQuestionLabel.TabIndex = 9;
            deleteQuestionLabel.Text = "Выделите строку с вопросом, который нужно удалить!";
            deleteQuestionLabel.Visible = false;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.Enabled = false;
            DeleteQuestionButton.Location = new Point(1241, 200);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(140, 47);
            DeleteQuestionButton.TabIndex = 10;
            DeleteQuestionButton.Text = "Удалить";
            DeleteQuestionButton.UseVisualStyleBackColor = true;
            DeleteQuestionButton.Visible = false;
            DeleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1484, 968);
            Controls.Add(addQuestionLabel);
            Controls.Add(answerTextBox);
            Controls.Add(addQuestionButton);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(deleteQuestionLabel);
            Controls.Add(questionTextBox);
            Controls.Add(resultPanel);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений - идиот";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            resultPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
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
        private ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private Label addQuestionLabel;
        private Button addQuestionButton;
        private TextBox answerTextBox;
        private TextBox questionTextBox;
    }
}