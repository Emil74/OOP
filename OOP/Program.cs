using OOP.lesson_2;
using OOP;
using OOP.lesson_3;
using OOP.lesson_4;
using OOP.lesson_5;

List<ILesson> task = new List<ILesson>()
            {
           new HomeWork2(),
           new HomeWork_3(),
           new HomeWork_4(),
           new HomeWork5()
};

foreach (ILesson lesson in task)
    Console.WriteLine($"Введите '{lesson.Name}' для вызова задания '{lesson.Description}' ");

Console.Write("Input task number - ");
string taskNumber = Console.ReadLine();
Console.WriteLine(new string('-', 50));
foreach (ILesson lesson in task)
{
    if (lesson.Name == taskNumber)
        lesson.Run();
}