namespace _2048WindowsFormsApp
{
    partial class ResultsForm
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
            this.resultsGridView = new System.Windows.Forms.DataGridView();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsGridView
            // 
            this.resultsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userName,
            this.userResult});
            this.resultsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultsGridView.Location = new System.Drawing.Point(0, 0);
            this.resultsGridView.Name = "resultsGridView";
            this.resultsGridView.RowHeadersWidth = 62;
            this.resultsGridView.RowTemplate.Height = 28;
            this.resultsGridView.Size = new System.Drawing.Size(548, 450);
            this.resultsGridView.TabIndex = 0;
            // 
            // userName
            // 
            this.userName.Frozen = true;
            this.userName.HeaderText = "Имя игрока";
            this.userName.MinimumWidth = 8;
            this.userName.Name = "userName";
            this.userName.Width = 150;
            // 
            // userResult
            // 
            this.userResult.Frozen = true;
            this.userResult.HeaderText = "Результат";
            this.userResult.MinimumWidth = 8;
            this.userResult.Name = "userResult";
            this.userResult.Width = 150;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 450);
            this.Controls.Add(this.resultsGridView);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            ((System.ComponentModel.ISupportInitialize)(this.resultsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView resultsGridView;
        public System.Windows.Forms.DataGridViewTextBoxColumn userName;
        public System.Windows.Forms.DataGridViewTextBoxColumn userResult;
    }
}