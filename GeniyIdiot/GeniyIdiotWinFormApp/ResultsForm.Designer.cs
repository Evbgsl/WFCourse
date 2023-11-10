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
            resultDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDataGridView.Columns.AddRange(new DataGridViewColumn[] { userName, Percent, userDiagnose });
            resultDataGridView.Location = new Point(-4, 12);
            resultDataGridView.Name = "resultDataGridView";
            resultDataGridView.RowHeadersWidth = 62;
            resultDataGridView.RowTemplate.Height = 33;
            resultDataGridView.Size = new Size(810, 380);
            resultDataGridView.TabIndex = 1;
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
            // ResultsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultDataGridView);
            Name = "ResultsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResultsForm";
            ((System.ComponentModel.ISupportInitialize)resultDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView resultDataGridView;
        public DataGridViewTextBoxColumn userName;
        public DataGridViewTextBoxColumn Percent;
        public DataGridViewTextBoxColumn userDiagnose;
    }
}