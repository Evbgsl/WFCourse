public class Question
{
    public string Text;
    public int Answer;

    public Question(string text, int answer)
    {
        Text = text ?? throw new ArgumentNullException(nameof(text));
        Answer = answer;
    }
}
