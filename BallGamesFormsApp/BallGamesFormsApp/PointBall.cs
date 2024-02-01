namespace BallGamesFormsApp
{
    public class PointBall : Ball
        {
            public PointBall(MainForm form, int x, int y) : base(form)
            {
                this.x = x - ballSize / 2;
                this.y = y - ballSize / 2;
            }
        }
 
}