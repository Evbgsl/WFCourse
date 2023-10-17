using System.IO;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Как Вас зовут?");

var userName = new User(Console.ReadLine());

var questions = new List<Question>
{
    new Question("Два плюс два умножить на два?", 6),
    new Question("Сколько нужно распилов, чтобы разделить бревно на 10 частей?", 9),
    new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
    new Question("Укол делают 1 раз в 30 минут. Сколько нужно мин на 3 укола?", 60),
    new Question("5 свечей горело, 2 потухли. Сколько свечей сгорело?", 2)
};

var diagnosis = new List<Diagnose>
{
    new Diagnose("Идиот"),
    new Diagnose("Кретин"),
    new Diagnose("Дурак"),
    new Diagnose("Нормальный"),
    new Diagnose("Талант"),
    new Diagnose("Гений")
};

bool flagRepeatTest = true;

var path = @"results.txt";

while (flagRepeatTest) 
{
    var _questions = new List<Question>(questions);
    var random = new Random();
    var countQuestions = questions.Count;
    var countRightAnswers = 0;
    
    for (int i = 0; i < countQuestions; i++)
    {
        Console.WriteLine("Номер вопроса " + (i + 1));

        var randomQuestionIndex = random.Next(0, _questions.Count);
        Console.WriteLine(_questions[randomQuestionIndex].Text);

        var rightAnswer = _questions[randomQuestionIndex].Answer;

        var userAnswer = UserStorage.GetUserAnswer();

        _questions.RemoveAt(randomQuestionIndex);
        
        if (userAnswer == rightAnswer)
        {
            countRightAnswers++;
        }
    }

    Console.WriteLine("Кол-во прав ответов: " + countRightAnswers);
    var percentOfRightAnswers = 100* countRightAnswers / countQuestions;

    var userDiagnose = DiagnoseStorage.GetDiagnose(diagnosis, percentOfRightAnswers);


    Console.WriteLine(userName.Name + ", Ваш диагноз: " + userDiagnose);
    
    var testResult = $"{userName.Name},{percentOfRightAnswers},{userDiagnose}";


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

