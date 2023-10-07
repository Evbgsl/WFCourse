Console.WriteLine("Как Вас зовут?");
string UserName = Console.ReadLine();

bool flagRepeatTest = true;

while (flagRepeatTest) 
{ 
    int countRightAnswers = 0;
    var random = new Random();
    var numbersOfRandom = new List<int>();
    for (int i=0; i < 5; i++)
    {
        int index = random.Next(0, 5);
        if (numbersOfRandom.Contains(index))
        {
            i--;
            continue;    
        }
        Console.WriteLine("Номер вопроса " + (i+1));
        Console.WriteLine(GetQuestion(index));
        int userAnswer = Convert.ToInt32(Console.ReadLine());
        int rightAnswer = GetRightAnswer(index);
        if (userAnswer == rightAnswer)
        {
            countRightAnswers++;
        }
        numbersOfRandom.Add(index);
    }

    Console.WriteLine("Кол-во прав ответов: " + countRightAnswers);
    Console.WriteLine(UserName + ", Ваш диагноз: " + GetDiagnose(countRightAnswers));

    Console.WriteLine("Желаете повторить тест?");
    if (Console.ReadLine() == "да")
    {
        flagRepeatTest = true;
    }
    else {flagRepeatTest = false;}   
}

static string GetQuestion(int n)
{
    string[] questions = new string[5];
    questions[0] = "Два плюс два умн на два?";
    questions[1] = "Бревно на 10 частей?";
    questions[2] = "Сколько пальцев на 5 руках?";
    questions[3] = "Сколько мин на 3 укола?";
    questions[4] = "5 горело, 2 потухли - сколько сгорело?";

    return questions[n];
}

static int GetRightAnswer(int n)
{
    int[] answers = new int[5];
    answers[0] = 6;
    answers[1] = 9;
    answers[2] = 25;
    answers[3] = 60;
    answers[4] = 2;

    return answers[n];
}

static string GetDiagnose(int n)
{
    string[] diagnosis = new string[6];
    diagnosis[0] = "Идиот";
    diagnosis[1] = "Кретин";
    diagnosis[2] = "Дурак";
    diagnosis[3] = "Нормальный";
    diagnosis[4] = "Талант";
    diagnosis[5] = "Гений";

    return diagnosis[n];
}
