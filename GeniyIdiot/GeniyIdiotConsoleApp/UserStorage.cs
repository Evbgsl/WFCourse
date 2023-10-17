public class UserStorage
{
    public List<int> UserAnswers;
    
    public UserStorage(List<int> userAnswers)
    {
        UserAnswers = userAnswers;

    }

    public static int GetUserAnswer()
    {
        while (true)
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }



}
