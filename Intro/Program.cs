// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
int term = 12;
double amount = 10000.5;


//variables --> named as camelCase
bool isAuthenticated = false;
Console.WriteLine(message1);

//condition
if (isAuthenticated == true)
{
    Console.WriteLine("Hoşgeldin Ceyda");
}
else
{
    Console.WriteLine("sisteme giriş yap");
}



string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3 ", "Kredi 4", "Kredi 5", "Kredi 6" };
//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

     //start       condition      increment  
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}




for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + "/" + courses[i].Price);
}

CourseManager courseManager = new CourseManager();
courseManager.GetAll();
courseManager.Team();

Console.WriteLine("kod bitti");