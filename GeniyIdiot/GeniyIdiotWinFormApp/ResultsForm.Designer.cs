namespace GeniyIdiotWinFormApp
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
            resultDataGridView = new DataGridView();
            userName = new DataGridViewTextBoxColumn();
            Percent = new DataGridViewTextBoxColumn();
            userDiagnose = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).BeginInit();
            SuspendLayout();
            // 
            // resultDataGridView
            // 
            resultDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { userName, Percent, userDiagnose });
            resultDataGridView.Dock = DockStyle.Fill;
            resultDataGridView.Location = new Point(0, 0);
            resultDataGridView.Margin = new Padding(2);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowHeadersWidth = 62;
            resultDataGridView.RowTemplate.Height = 33;
            resultDataGridView.Size = new Size(669, 310);
            resultDataGridView.TabIndex = 1;
            // 
            // userName
            // 
            userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userName.HeaderText = "Пользователь";
            userName.MinimumWidth = 8;
            userName.Name = "userName";
            // 
            // Percent
            // 
            Percent.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Percent.HeaderText = "Кол верных";
            Percent.MinimumWidth = 8;
            Percent.Name = "Percent";
            // 
            // userDiagnose
            // 
            userDiagnose.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            userDiagnose.HeaderText = "Диагноз";
            userDiagnose.MinimumWidth = 8;
            userDiagnose.Name = "userDiagnose";
            // 
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 310);
            Controls.Add(resultDataGridView);
            Margin = new Padding(2);
            Name = "ResultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultsForm";
            FormClosing += ResultsForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView resultDataGridView;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn Percent;
        private DataGridViewTextBoxColumn userDiagnose;
    }
}