using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BallGamesFormsApp
{
    public class Ball
    {
        private MainForm form;
        protected int x = 150;
        protected int y = 150;

        protected static Random random = new Random();

        private int vx;
        private int vy;

        private int randomVx;
        private int randomVy;

        protected int ballSize = 70;

        public Ball(MainForm form)
        {
            this.form = form;
        }

        public void Show()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            var rectangle = new Rectangle(x, y, ballSize, ballSize);
            graphics.FillEllipse(brush, rectangle);
        }

        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, ballSize, ballSize);
            graphics.FillEllipse(brush, rectangle);

        }

        public void Randomizer()
        {
            randomVx = random.Next(2) * 2 - 1;
            randomVy = random.Next(2) * 2 - 1;

            vx = random.Next(2,20) * randomVx;
            vy = random.Next(2, 20) * randomVy;
        }

        private void Go() 
        {
            x += vx;
            y += vy;        
        }

        public void Move()
        {
            Clear();
            Go();
            Show();
        
        }
    }

}