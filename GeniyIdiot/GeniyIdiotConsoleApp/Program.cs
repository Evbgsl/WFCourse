using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Как Вас зовут?");

var userName = new User(Console.ReadLine());
string fileName = @"datafile.txt";
var value = DataFileProvider.GetValue(fileName);
var questions = QuestionsStorage.GetQuestions(value);
var diagnoses = new List<Diagnose>
{
    new Diagnose("Идиот"),
    new Diagnose("Кретин"),
    new Diagnose("Дурак"),
    new Diagnose("Нормальный"),
    new Diagnose("Талант"),
    new Diagnose("Гений")
};
bool flagRepeatTest = true;
static bool GetUserChoice(string question)
{
    Console.WriteLine($"{question}");
    if (Console.ReadLine().ToLower() == "да")
    { return true; }
    else { return false; }

}

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

        var userAnswer = UserStorage.GetNumber();

        _questions.RemoveAt(randomQuestionIndex);

        if (userAnswer == rightAnswer)
        {
            countRightAnswers++;
        }
    }

    Console.WriteLine("Кол-во прав ответов: " + countRightAnswers);
    var percentOfRightAnswers = 100 * countRightAnswers / countQuestions;

    var userDiagnose = DiagnoseStorage.GetDiagnose(diagnoses, percentOfRightAnswers);


    Console.WriteLine(userName.Name + ", Ваш диагноз: " + userDiagnose);
    UserStorage.SetResult(userName, percentOfRightAnswers, userDiagnose, fileName);
    
    Console.WriteLine("Желаете повторить тест?");
    if (Console.ReadLine() == "да")
    {
        flagRepeatTest = true;
    }
    else { flagRepeatTest = false; }
}

var userChoice = GetUserChoice("Показать результаты предыдущих тестов?");
if (userChoice)
{
    UserStorage.GetResultsFromFile(fileName);
}

userChoice = GetUserChoice("Хотите добавить вопрос? ");
if (userChoice)
{    
    QuestionsStorage.SetQuestionToFile(fileName);
    return;
}

userChoice = GetUserChoice("Хотите удалить вопрос?");
if (userChoice)
{
    Console.WriteLine("Введите ID вопроса, который следует удалить");
    var id = Console.ReadLine();
    QuestionsStorage.RemoveQuestionFromFile(fileName, id);
    return;
}
