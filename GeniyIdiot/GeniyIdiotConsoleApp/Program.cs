using System.IO;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Как Вас зовут?");
string UserName = Console.ReadLine();
// ...
bool flagRepeatTest = true;

var path = @"results.txt";

while (flagRepeatTest) 
{
    var questions = GetQuestion();
    var answers = GetAnswer();
    var countQuestions = questions.Count;
    var countRightAnswers = 0;
    
    var random = new Random();

    for (int i = 0; i < countQuestions; i++)
    {
        Console.WriteLine("Номер вопроса " + (i + 1));

        var randomQuestionIndex = random.Next(0, questions.Count);

        Console.WriteLine(questions[randomQuestionIndex]);

        var rightAnswer = answers[randomQuestionIndex];

        var userAnswer = GetUserAnswer();

        questions.RemoveAt(randomQuestionIndex);
        answers.RemoveAt(randomQuestionIndex);

        if (userAnswer == rightAnswer)
        {
            countRightAnswers++;
        }

    }


    Console.WriteLine("Кол-во прав ответов: " + countRightAnswers);
    var percentOfRightAnswers = GetPercentOfRightAnswers(countQuestions, countRightAnswers);
    var diagnose = GetDiagnose(percentOfRightAnswers);
    Console.WriteLine(UserName + ", Ваш диагноз: " + diagnose);
    
    var testResult = $"{UserName},{percentOfRightAnswers},{diagnose}";


    using (StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default))
    {
        sw.WriteLine(testResult);
    }

    Console.WriteLine("Желаете повторить тест?");
    if (Console.ReadLine() == "да")
    {
        flagRepeatTest = true;
    }
    else {flagRepeatTest = false;}   
}



Console.WriteLine("Показать результаты предыдущих тестов?");
if (Console.ReadLine() == "да")
{
    Console.WriteLine("{0,20} | {1,20} | {2, 20}", "ФИО", "% верных ответов", "Диагноз");
    using (StreamReader sr = new StreamReader(path))
    {
        string? line;
        while ((line = sr.ReadLine()) != null)
        {
            var lineArray = line.Split(",");
            Console.WriteLine("{0,20} | {1,20} | {2,20}", lineArray[0], lineArray[1], lineArray[2]);
        }
    }
}


static int GetUserAnswer()
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
static List<string> GetQuestion()
{
    var questions = new List<string>();
    questions.Add("Два плюс два умн на два?");
    questions.Add("Бревно на 10 частей?");
    questions.Add("Сколько пальцев на 5 руках?");
    questions.Add("Сколько мин на 3 укола?");
    questions.Add("5 горело, 2 потухли - сколько сгорело?");
    return questions;
}
static List<int> GetAnswer()
{
    var answers = new List<int>();
    answers.Add(6);
    answers.Add(9);
    answers.Add(25);
    answers.Add(60);
    answers.Add(2);

    return answers;
}
static string GetDiagnose(int percentOfRightAnswers)
{    
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
static int GetPercentOfRightAnswers(int countQuestions, int countRightAnswers)
{
    return (int)Math.Round(100.0 * countRightAnswers / countQuestions);
}