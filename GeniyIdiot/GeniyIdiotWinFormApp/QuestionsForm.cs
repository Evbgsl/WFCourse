using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormApp
{
    public partial class QuestionsForm : Form
    {

        public event EventHandler DeleteQuestionButtonClickEvent;
        public event EventHandler questionsDataGridViewSelectionChanged;

        public QuestionsForm()
        {
            InitializeComponent();
        }



        private void DeleteQuestionButton_Click(object sender, EventArgs e)
        {

            if (DeleteQuestionButtonClickEvent != null)
            {
                DeleteQuestionButtonClickEvent(this, EventArgs.Empty);
            }

        }

        private void questionsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            questionsDataGridViewSelectionChanged?.Invoke(this, EventArgs.Empty);

        }

        private void QuestionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Отменить закрытие формы
            this.Hide(); // Скрыть форму
        }
    }


}
