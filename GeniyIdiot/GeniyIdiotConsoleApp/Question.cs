public class Question
{
    public string Id { get; set; }
    public string Text { get; set; }
    public int Answer { get; set; }

    public Question(string id, string text, int answer)
    {
        Id = id;
        Text = text;
        Answer = answer;
    }
}
