using System;
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

        List<MoveBall> moveBalls;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            var pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           moveBalls = new List<MoveBall>();
            for (int i = 0; i < 8; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Randomizer();
                moveBall.Start();
            }
        }

        private void moveBallButton_Click(object sender, EventArgs e)
        {
            int countBalls = 0;

            for (int i = 0; i < 8; i++)
            {
                moveBalls[i].Stop();
            }

            for (int i = 0; i < 8; i++)
            {
                if (moveBalls[i].CheckBallInForm()) countBalls++;
            }

            MessageBox.Show(countBalls.ToString());

        }
    }
}
