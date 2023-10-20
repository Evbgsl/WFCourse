using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Как Вас зовут?");

var userName = new User(Console.ReadLine());

var dataFileProvider = new DataFileProvider();
dataFileProvider.DataFilePath = @"datafile.txt";

var questions = DataFileProvider.GetQuestionsFromFile(dataFileProvider.DataFilePath);

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
        Console.WriteLine($"ID вопроса: {_questions[randomQuestionIndex].Id} {_questions[randomQuestionIndex].Text}");

        var rightAnswer = _questions[randomQuestionIndex].Answer;

        var userAnswer = UserStorage.GetUserAnswer();

        _questions.RemoveAt(randomQuestionIndex);

        if (userAnswer == rightAnswer)
        {
            countRightAnswers++;
        }
    }

    Console.WriteLine("Кол-во прав ответов: " + countRightAnswers);
    var percentOfRightAnswers = 100 * countRightAnswers / countQuestions;

    var userDiagnose = DiagnoseStorage.GetDiagnose(diagnosis, percentOfRightAnswers);


    Console.WriteLine(userName.Name + ", Ваш диагноз: " + userDiagnose);

    DataFileProvider.SetResultToFile(userName, percentOfRightAnswers, userDiagnose, dataFileProvider.DataFilePath);


    Console.WriteLine("Желаете повторить тест?");
    if (Console.ReadLine() == "да")
    {
        flagRepeatTest = true;
    }
    else { flagRepeatTest = false; }
}

Console.WriteLine("Показать результаты предыдущих тестов?");
if (Console.ReadLine() == "да")
{
    DataFileProvider.GetResultsFromFile(dataFileProvider.DataFilePath);
}

Console.WriteLine("Хотите добавить вопрос? ");
if (Console.ReadLine() == "да")
{
    Console.WriteLine("Введите через знак & текст вопрос и цифру с правильным ответом");
    DataFileProvider.SetQuestionToFile(dataFileProvider.DataFilePath);
    return;
}

Console.WriteLine("Хотите удалить вопрос? ");
if (Console.ReadLine() == "да")
{
    Console.WriteLine("Введите ID вопроса, который следует удалить");
    var id = Console.ReadLine();
    DataFileProvider.RemoveQuestionFromFile(dataFileProvider.DataFilePath, id);
    return;
}

