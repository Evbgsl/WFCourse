namespace BallGamesFormsApp
{
    public class RandomPointAndSizeBall : RandomPointBall
    {
        public RandomPointAndSizeBall(MainForm form) : base(form)
        {
            this.ballSize = random.Next(10, 70);
        }
    }

}