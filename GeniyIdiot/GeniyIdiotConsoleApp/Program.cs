Console.WriteLine("Как Вас зовут?");
string UserName = Console.ReadLine();
// ...
bool flagRepeatTest = true;

while (flagRepeatTest) 
{ 
    int countQuestions = 5;
    int countRightAnswers = 0;
    var random = new Random();
    var numbersOfRandom = new List<int>();
    for (int i=0; i < countQuestions; i++)
    {
        int index = random.Next(0, countQuestions);
        if (numbersOfRandom.Contains(index))
        {
            i--;
            continue;    
        }
        Console.WriteLine("Номер вопроса " + (i+1));
        Console.WriteLine(GetQuestion(countQuestions, index));
        bool flag = false;
        int userAnswer = 0;

        while (!flag)
        {
            var ans_string = Console.ReadLine();
            flag = int.TryParse(ans_string, out userAnswer);
            if (!flag) {Console.WriteLine("Пожалуйста, введите число!");}
        }

        int rightAnswer = GetRightAnswer(index);
        if (userAnswer == rightAnswer)
        {
            countRightAnswers++;
        }
        numbersOfRandom.Add(index);
    }

    Console.WriteLine("Кол-во прав ответов: " + countRightAnswers);
    Console.WriteLine(UserName + ", Ваш диагноз: " + GetDiagnose(countQuestions, countRightAnswers));

    Console.WriteLine("Желаете повторить тест?");
    if (Console.ReadLine() == "да")
    {
        flagRepeatTest = true;
    }
    else {flagRepeatTest = false;}   
}

static string GetQuestion(int countQuestions, int n)
{
    string[] questions = new string[countQuestions];
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

static string GetDiagnose(int countQuestions, int countRightAnswers)
{


    int percentOfRightAnswers = (int)Math.Round(100.0 * countRightAnswers / countQuestions);
    int n = 0;

    if (percentOfRightAnswers <= 16)
    {
        n = 0;
    }
    else if (percentOfRightAnswers <= 32)
    {
        n = 1;
    }
    else if (percentOfRightAnswers <= 48)
    {
        n = 2;
    }
    else if (percentOfRightAnswers <= 64)
    {
        n = 3;
    }
    else if (percentOfRightAnswers <= 80)
    {
        n = 4;
    }
    // Add more conditions for other score ranges as needed
    else
    {
        n = 5; // Default case if the percentage is above all defined ranges
    }



    string[] diagnosis = new string[6];
    diagnosis[0] = "Идиот";
    diagnosis[1] = "Кретин";
    diagnosis[2] = "Дурак";
    diagnosis[3] = "Нормальный";
    diagnosis[4] = "Талант";
    diagnosis[5] = "Гений";

    return diagnosis[n];
}
