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
            this.drawBall = new System.Windows.Forms.Button();
            this.drawRandomBall = new System.Windows.Forms.Button();
            this.drawRandomSizeBall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drawBall
            // 
            this.drawBall.Location = new System.Drawing.Point(13, 23);
            this.drawBall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawBall.Name = "drawBall";
            this.drawBall.Size = new System.Drawing.Size(212, 74);
            this.drawBall.TabIndex = 0;
            this.drawBall.Text = "Рисовать шарик";
            this.drawBall.UseVisualStyleBackColor = true;
            this.drawBall.Click += new System.EventHandler(this.drawBall_Click);
            // 
            // drawRandomBall
            // 
            this.drawRandomBall.Location = new System.Drawing.Point(233, 23);
            this.drawRandomBall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawRandomBall.Name = "drawRandomBall";
            this.drawRandomBall.Size = new System.Drawing.Size(355, 74);
            this.drawRandomBall.TabIndex = 1;
            this.drawRandomBall.Text = "Рисовать случайный шарик";
            this.drawRandomBall.UseVisualStyleBackColor = true;
            this.drawRandomBall.Click += new System.EventHandler(this.drawRandomBall_Click);
            // 
            // drawRandomSizeBall
            // 
            this.drawRandomSizeBall.Location = new System.Drawing.Point(596, 23);
            this.drawRandomSizeBall.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drawRandomSizeBall.Name = "drawRandomSizeBall";
            this.drawRandomSizeBall.Size = new System.Drawing.Size(414, 74);
            this.drawRandomSizeBall.TabIndex = 2;
            this.drawRandomSizeBall.Text = "Рисовать случайный шарик в случайном месте";
            this.drawRandomSizeBall.UseVisualStyleBackColor = true;
            this.drawRandomSizeBall.Click += new System.EventHandler(this.drawRandomSizeBall_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.drawRandomSizeBall);
            this.Controls.Add(this.drawRandomBall);
            this.Controls.Add(this.drawBall);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Мячики";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawBall;
        private System.Windows.Forms.Button drawRandomBall;
        private System.Windows.Forms.Button drawRandomSizeBall;
    }
}

