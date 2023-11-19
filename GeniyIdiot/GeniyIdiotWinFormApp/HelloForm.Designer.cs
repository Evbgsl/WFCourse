namespace GeniyIdiotWinFormApp
{
    partial class HelloForm
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
            label1 = new Label();
            label2 = new Label();
            userNameTextBox = new TextBox();
            startButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 25);
            label1.TabIndex = 0;
            label1.Text = "Добро пожаловать! ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(235, 25);
            label2.TabIndex = 1;
            label2.Text = "Введите имя пользователя!";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(49, 172);
            userNameTextBox.Margin = new Padding(4, 5, 4, 5);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(301, 31);
            userNameTextBox.TabIndex = 2;
            userNameTextBox.KeyDown += userNameTextBox_KeyDown;
            // 
            // startButton
            // 
            startButton.Location = new Point(49, 235);
            startButton.Margin = new Padding(4, 5, 4, 5);
            startButton.Name = "startButton";
            startButton.Size = new Size(303, 38);
            startButton.TabIndex = 3;
            startButton.Text = "Начать тест";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // HelloForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 315);
            ControlBox = false;
            Controls.Add(startButton);
            Controls.Add(userNameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "HelloForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений - идиот";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public TextBox userNameTextBox;
        private Button startButton;
    }
}