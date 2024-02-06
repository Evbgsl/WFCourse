using System;

namespace BallGamesFormsApp
{
    public class RandomPointBall : Ball
    {
        
        public RandomPointBall(MainForm form) : base(form)
        {
            x = random.Next(0, form.ClientSize.Width - 100);
            y = random.Next(0, form.ClientSize.Height - 100);
        }
    }

}