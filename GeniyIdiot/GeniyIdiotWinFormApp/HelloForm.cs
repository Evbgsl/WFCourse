﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormApp
{
    public partial class HelloForm : Form
    {

        public HelloForm()
        {
            InitializeComponent();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("Введите имя пользователя", "Гений - идиот");
                return;
            }
            {
                Close();
            }
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (string.IsNullOrEmpty(userNameTextBox.Text))
                {
                    MessageBox.Show("Введите имя пользователя", "Гений - идиот");
                    return;
                }
                {
                    Close();
                }
                
                // Ваш код для обработки нажатия Enter
                e.Handled = true;
                e.SuppressKeyPress = true;
            }




        }
    }
}
