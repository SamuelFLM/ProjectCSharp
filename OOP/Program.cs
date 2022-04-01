using OOP.ContentContext;
using OOP.ContentContext.Enums;
using OOP.NotificationContext;
using OOP.SubscriptionContext;

var articles = new List<Article>();

articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre c#", "csharp"));
articles.Add(new Article("Artigo sobre .net", "dotnet"));

foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
}


var courses = new List<Course>();
var courseOOP = new Course("Fundamentos OOP", "fundamentos orientacao");
var courseCsharp = new Course("Fundamentos C#", "fundamentos c#");
var course = new Course("Fundamentos ASP.NET", "fundamentos aspNET");

courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(course);

var careers = new List<Career>();
var careerDotnet = new Career("Especialista .NET", "Especialista-dotnet");
var careetItem = new CareerItem(1, "Comece por aqui", "", courseOOP);
var careetItem2 = new CareerItem(2, "Comece por aqui", "", null);
var careetItem3 = new CareerItem(3, "Comece por aqui", "", courseCsharp);
careerDotnet.Items.Add(careetItem);
careers.Add(careerDotnet);


foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    //Ordenação de Lista
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        foreach (var notification in item.Notificatios)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();

student.CreateSubscription(payPalSubscription);
