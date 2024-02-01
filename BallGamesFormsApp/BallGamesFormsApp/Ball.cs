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
    }

}