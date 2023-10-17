public class QuestionsStorage
{
    public Question? Questions;

    public QuestionsStorage(Question? questions)
    {
        Questions = questions;
    }

    public Question GetQuestion(List<Question> questions, int index)
    {
       return questions[index];
    }

}
