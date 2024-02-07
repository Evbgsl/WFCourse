namespace BallGamesFormsApp
{
    partial class MainForm
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
            this.moveBallButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moveBallButton
            // 
            this.moveBallButton.Location = new System.Drawing.Point(749, 38);
            this.moveBallButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.moveBallButton.Name = "moveBallButton";
            this.moveBallButton.Size = new System.Drawing.Size(390, 74);
            this.moveBallButton.TabIndex = 0;
            this.moveBallButton.Text = "Поймать все";
            this.moveBallButton.UseVisualStyleBackColor = true;
            this.moveBallButton.Click += new System.EventHandler(this.moveBallButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 74);
            this.button1.TabIndex = 3;
            this.button1.Text = "Запустить шарики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moveBallButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Мячики";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button moveBallButton;
        private System.Windows.Forms.Button button1;
    }
}

