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
            показатьВопросыToolStripMenuItem = new ToolStripMenuItem();
            questionsDataGridView = new DataGridView();
            IdQuestion = new DataGridViewTextBoxColumn();
            Queistion = new DataGridViewTextBoxColumn();
            Answer = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            nextButton.Location = new Point(26, 359);
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
            questionNumberLabel.Location = new Point(26, 130);
            questionNumberLabel.Margin = new Padding(4, 0, 4, 0);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(108, 25);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.AutoSize = true;
            questionTextLabel.Location = new Point(26, 182);
            questionTextLabel.Margin = new Padding(4, 0, 4, 0);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(129, 25);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(26, 263);
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
            menuStrip1.Size = new Size(987, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { начатьЗановоToolStripMenuItem, показатьВопросыToolStripMenuItem, показатьРезульToolStripMenuItem, выходToolStripMenuItem, оПрограммеToolStripMenuItem });
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
            // addNewUserButton
            // 
            addNewUserButton.Location = new Point(541, 63);
            addNewUserButton.Name = "addNewUserButton";
            addNewUserButton.Size = new Size(111, 38);
            addNewUserButton.TabIndex = 6;
            addNewUserButton.Text = "Добавить";
            addNewUserButton.UseVisualStyleBackColor = true;
            addNewUserButton.Click += addNewUserButton_Click;
            // 
            // newUserTextBox
            // 
            newUserTextBox.Location = new Point(226, 63);
            newUserTextBox.Name = "newUserTextBox";
            newUserTextBox.Size = new Size(271, 31);
            newUserTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 68);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 7;
            label1.Text = "Новый пользователь";
            // 
            // resultPanel
            // 
            resultPanel.Controls.Add(questionsDataGridView);
            resultPanel.Controls.Add(resultDataGridView);
            resultPanel.Location = new Point(332, 263);
            resultPanel.Name = "resultPanel";
            resultPanel.Size = new Size(620, 249);
            resultPanel.TabIndex = 8;
            resultPanel.Visible = false;
            // 
            // resultDataGridView
            // 
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { userName, Percent, userDiagnose });
            resultDataGridView.Location = new Point(31, 3);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowHeadersWidth = 62;
            resultDataGridView.RowTemplate.Height = 33;
            resultDataGridView.Size = new Size(560, 233);
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
            // показатьВопросыToolStripMenuItem
            // 
            показатьВопросыToolStripMenuItem.Name = "показатьВопросыToolStripMenuItem";
            показатьВопросыToolStripMenuItem.Size = new Size(285, 34);
            показатьВопросыToolStripMenuItem.Text = "Показать вопросы";
            показатьВопросыToolStripMenuItem.Click += показатьВопросыToolStripMenuItem_Click;
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdQuestion, Queistion, Answer });
            questionsDataGridView.Location = new Point(31, 3);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 62;
            questionsDataGridView.RowTemplate.Height = 33;
            questionsDataGridView.Size = new Size(560, 233);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 578);
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
            Margin = new Padding(4, 5, 4, 5);
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
    }
}