namespace GeniyIdiotWinFormApp
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
            resultDataGridView = new DataGridView();
            userName = new DataGridViewTextBoxColumn();
            Percent = new DataGridViewTextBoxColumn();
            userDiagnose = new DataGridViewTextBoxColumn();
            addQuestionButton = new Button();
            answerTextBox = new TextBox();
            questionTextBox = new TextBox();
            addQuestionLabel = new Label();
            menuStrip1.SuspendLayout();
            resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nextButton.Location = new Point(18, 127);
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
            questionNumberLabel.Location = new Point(18, 38);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(70, 15);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(18, 65);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(85, 15);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(18, 83);
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
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { начатьЗановоToolStripMenuItem, показатьВопросыToolStripMenuItem, показатьРезульToolStripMenuItem, выходToolStripMenuItem, оПрограммеToolStripMenuItem, добавитьВопросToolStripMenuItem });
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
            // добавитьВопросToolStripMenuItem
            // 
            добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            добавитьВопросToolStripMenuItem.Size = new Size(189, 22);
            добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            добавитьВопросToolStripMenuItem.Click += добавитьВопросToolStripMenuItem_Click;
            // 
            // resultPanel
            // 
            resultPanel.Controls.Add(resultDataGridView);
            resultPanel.Location = new Point(385, 178);
            resultPanel.Margin = new Padding(2);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new Size(586, 253);
            resultPanel.TabIndex = 8;
            resultPanel.Visible = false;
            // 
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { userName, Percent, userDiagnose });
            resultDataGridView.Location = new Point(2, 13);
            resultDataGridView.Margin = new Padding(2);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowHeadersWidth = 62;
            resultDataGridView.RowTemplate.Height = 33;
            resultDataGridView.Size = new Size(567, 228);
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
            addQuestionButton.Location = new Point(18, 330);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(130, 23);
            addQuestionButton.TabIndex = 11;
            addQuestionButton.Text = "Добавить вопрос";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Visible = false;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(298, 283);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(69, 23);
            answerTextBox.TabIndex = 11;
            answerTextBox.Visible = false;
            // 
            // questionTextBox
            // 
            questionTextBox.Location = new Point(18, 283);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(256, 23);
            questionTextBox.TabIndex = 11;
            questionTextBox.Visible = false;
            // 
            // addQuestionLabel
            // 
            addQuestionLabel.AutoSize = true;
            addQuestionLabel.Location = new Point(18, 249);
            addQuestionLabel.Name = "addQuestionLabel";
            addQuestionLabel.Size = new Size(172, 15);
            addQuestionLabel.TabIndex = 11;
            addQuestionLabel.Text = "Введите текст вопроса и ответ";
            addQuestionLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 581);
            Controls.Add(addQuestionLabel);
            Controls.Add(answerTextBox);
            Controls.Add(addQuestionButton);
            Controls.Add(questionTextBox);
            Controls.Add(resultPanel);
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
        private ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private Label addQuestionLabel;
        private Button addQuestionButton;
        private TextBox answerTextBox;
        private TextBox questionTextBox;
    }
}