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
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; // Отменить закрытие формы
            this.Hide(); // Скрыть форму
        }
    }
}
