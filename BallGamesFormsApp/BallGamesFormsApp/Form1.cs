﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BallGamesFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void drawBall_Click(object sender, EventArgs e)
        {
            var ball = new Ball(this);
            ball.Show();
        }

        private void drawRandomBall_Click(object sender, EventArgs e)
        {
            var randomPointBall = new RandomPointBall(this);
            randomPointBall.Show();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();


        }

        private void drawRandomSizeBall_Click(object sender, EventArgs e)
        {
            var randomSizePointBall = new RandomPointAndSizeBall(this);
            randomSizePointBall.Show();
        }
    }
}