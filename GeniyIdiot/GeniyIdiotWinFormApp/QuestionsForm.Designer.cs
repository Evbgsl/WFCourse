namespace GeniyIdiotWinFormApp
{
    partial class QuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionsDataGridView = new DataGridView();
            DeleteQuestionButton = new Button();
            deleteQuestionLabel = new Label();
            IdQuestion = new DataGridViewTextBoxColumn();
            Question = new DataGridViewTextBoxColumn();
            Answer = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdQuestion, Question, Answer });
            questionsDataGridView.Dock = DockStyle.Top;
            questionsDataGridView.Location = new Point(0, 0);
            questionsDataGridView.Margin = new Padding(2);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 62;
            questionsDataGridView.RowTemplate.Height = 33;
            questionsDataGridView.Size = new Size(425, 261);
            questionsDataGridView.TabIndex = 2;
            questionsDataGridView.SelectionChanged += questionsDataGridView_SelectionChanged;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.Enabled = false;
            DeleteQuestionButton.Location = new Point(322, 280);
            DeleteQuestionButton.Margin = new Padding(2);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(98, 28);
            DeleteQuestionButton.TabIndex = 12;
            DeleteQuestionButton.Text = "Удалить";
            DeleteQuestionButton.UseVisualStyleBackColor = true;
            DeleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // deleteQuestionLabel
            // 
            deleteQuestionLabel.AutoSize = true;
            deleteQuestionLabel.Location = new Point(11, 287);
            deleteQuestionLabel.Margin = new Padding(2, 0, 2, 0);
            deleteQuestionLabel.Name = "deleteQuestionLabel";
            deleteQuestionLabel.Size = new Size(307, 15);
            deleteQuestionLabel.TabIndex = 11;
            deleteQuestionLabel.Text = "Выделите строку с вопросом, который нужно удалить";
            // 
            // IdQuestion
            // 
            IdQuestion.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            IdQuestion.Frozen = true;
            IdQuestion.HeaderText = "ID вопроса";
            IdQuestion.MinimumWidth = 8;
            IdQuestion.Name = "IdQuestion";
            IdQuestion.Width = 75;
            // 
            // Question
            // 
            Question.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Question.HeaderText = "Вопрос";
            Question.MinimumWidth = 8;
            Question.Name = "Question";
            // 
            // Answer
            // 
            Answer.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Answer.HeaderText = "Ответ";
            Answer.MinimumWidth = 8;
            Answer.Name = "Answer";
            Answer.Width = 50;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 325);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(deleteQuestionLabel);
            Controls.Add(questionsDataGridView);
            Name = "QuestionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuestionsForm";
            FormClosing += QuestionsForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView questionsDataGridView;
        public Button DeleteQuestionButton;
        private Label deleteQuestionLabel;
        private DataGridViewTextBoxColumn IdQuestion;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn Answer;
    }
}