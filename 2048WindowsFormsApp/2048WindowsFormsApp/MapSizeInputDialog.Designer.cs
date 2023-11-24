namespace _2048WindowsFormsApp
{
    partial class MapSizeInputDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.mapSizeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите размер игрового поля";
            // 
            // mapSizeTextBox
            // 
            this.mapSizeTextBox.Location = new System.Drawing.Point(206, 14);
            this.mapSizeTextBox.Name = "mapSizeTextBox";
            this.mapSizeTextBox.Size = new System.Drawing.Size(42, 20);
            this.mapSizeTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить и перезапустить игру";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MapSizeInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 86);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mapSizeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MapSizeInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox mapSizeTextBox;
        private System.Windows.Forms.Button button1;
    }
}