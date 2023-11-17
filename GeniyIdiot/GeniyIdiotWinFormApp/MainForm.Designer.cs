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
            components = new System.ComponentModel.Container();
            nextButton = new Button();
            questionNumberLabel = new Label();
            questionTextLabel = new Label();
            userAnswerTextBox = new TextBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            начатьЗановоToolStripMenuItem = new ToolStripMenuItem();
            показатьВопросыToolStripMenuItem = new ToolStripMenuItem();
            добавитьВопросToolStripMenuItem = new ToolStripMenuItem();
            показатьРезульToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            оПрограммеToolStripMenuItem = new ToolStripMenuItem();
            addQuestionButton = new Button();
            answerTextBox = new TextBox();
            questionTextBox = new TextBox();
            addQuestionLabel = new Label();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            finishLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.Location = new Point(17, 136);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(526, 38);
            nextButton.TabIndex = 0;
            nextButton.Text = "Далее...";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            questionNumberLabel.Location = new Point(234, 35);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(70, 15);
            questionNumberLabel.TabIndex = 1;
            questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            questionTextLabel.Anchor = AnchorStyles.Top;
            questionTextLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            questionTextLabel.Location = new Point(45, 67);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(466, 19);
            questionTextLabel.TabIndex = 2;
            questionTextLabel.Text = "Текст вопроса";
            questionTextLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Location = new Point(308, 102);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(40, 23);
            userAnswerTextBox.TabIndex = 3;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(562, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { начатьЗановоToolStripMenuItem, показатьВопросыToolStripMenuItem, добавитьВопросToolStripMenuItem, показатьРезульToolStripMenuItem, выходToolStripMenuItem, оПрограммеToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(53, 22);
            toolStripMenuItem1.Text = "Меню";
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
            // добавитьВопросToolStripMenuItem
            // 
            добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            добавитьВопросToolStripMenuItem.Size = new Size(189, 22);
            добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            добавитьВопросToolStripMenuItem.Click += добавитьВопросToolStripMenuItem_Click;
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
            // addQuestionButton
            // 
            addQuestionButton.Location = new Point(412, 245);
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
            answerTextBox.Location = new Point(331, 250);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(69, 23);
            answerTextBox.TabIndex = 11;
            answerTextBox.Visible = false;
            // 
            // questionTextBox
            // 
            questionTextBox.Location = new Point(17, 250);
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(310, 23);
            questionTextBox.TabIndex = 11;
            questionTextBox.Visible = false;
            // 
            // addQuestionLabel
            // 
            addQuestionLabel.AutoSize = true;
            addQuestionLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addQuestionLabel.Location = new Point(191, 226);
            addQuestionLabel.Name = "addQuestionLabel";
            addQuestionLabel.Size = new Size(176, 15);
            addQuestionLabel.TabIndex = 11;
            addQuestionLabel.Text = "Введите текст вопроса и ответ";
            addQuestionLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(191, 105);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 12;
            label1.Text = "Введите ответ";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Red;
            progressBar1.Location = new Point(17, 191);
            progressBar1.Margin = new Padding(2, 2, 2, 2);
            progressBar1.Maximum = 10;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(526, 20);
            progressBar1.Step = 1;
            progressBar1.TabIndex = 13;
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            finishLabel.Location = new Point(139, 201);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(283, 25);
            finishLabel.TabIndex = 14;
            finishLabel.Text = "Тест окончен, начните заново!";
            finishLabel.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 282);
            Controls.Add(finishLabel);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(addQuestionLabel);
            Controls.Add(answerTextBox);
            Controls.Add(addQuestionButton);
            Controls.Add(questionTextBox);
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
        private ToolStripMenuItem показатьВопросыToolStripMenuItem;
        private ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private Label addQuestionLabel;
        private Button addQuestionButton;
        private TextBox answerTextBox;
        private TextBox questionTextBox;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label finishLabel;
    }
}