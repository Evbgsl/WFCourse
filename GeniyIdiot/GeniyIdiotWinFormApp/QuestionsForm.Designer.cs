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
            IdQuestion = new DataGridViewTextBoxColumn();
            Question = new DataGridViewTextBoxColumn();
            Answer = new DataGridViewTextBoxColumn();
            DeleteQuestionButton = new Button();
            deleteQuestionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { IdQuestion, Question, Answer });
            questionsDataGridView.Location = new Point(3, 3);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.RowHeadersWidth = 62;
            questionsDataGridView.RowTemplate.Height = 33;
            questionsDataGridView.Size = new Size(737, 395);
            questionsDataGridView.TabIndex = 2;
            questionsDataGridView.SelectionChanged += questionsDataGridView_SelectionChanged;
            // 
            // IdQuestion
            // 
            IdQuestion.HeaderText = "ID вопроса";
            IdQuestion.MinimumWidth = 8;
            IdQuestion.Name = "IdQuestion";
            IdQuestion.Width = 150;
            // 
            // Question
            // 
            Question.HeaderText = "Вопрос";
            Question.MinimumWidth = 8;
            Question.Name = "Question";
            Question.Width = 150;
            // 
            // Answer
            // 
            Answer.HeaderText = "Ответ";
            Answer.MinimumWidth = 8;
            Answer.Name = "Answer";
            Answer.Width = 150;
            // 
            // DeleteQuestionButton
            // 
            DeleteQuestionButton.Enabled = false;
            DeleteQuestionButton.Location = new Point(556, 420);
            DeleteQuestionButton.Name = "DeleteQuestionButton";
            DeleteQuestionButton.Size = new Size(140, 47);
            DeleteQuestionButton.TabIndex = 12;
            DeleteQuestionButton.Text = "Удалить";
            DeleteQuestionButton.UseVisualStyleBackColor = true;
            DeleteQuestionButton.Click += DeleteQuestionButton_Click;
            // 
            // deleteQuestionLabel
            // 
            deleteQuestionLabel.AutoSize = true;
            deleteQuestionLabel.Location = new Point(53, 432);
            deleteQuestionLabel.Name = "deleteQuestionLabel";
            deleteQuestionLabel.Size = new Size(459, 25);
            deleteQuestionLabel.TabIndex = 11;
            deleteQuestionLabel.Text = "Выделите строку с вопросом, который нужно удалить";
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 485);
            Controls.Add(DeleteQuestionButton);
            Controls.Add(deleteQuestionLabel);
            Controls.Add(questionsDataGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "QuestionsForm";
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