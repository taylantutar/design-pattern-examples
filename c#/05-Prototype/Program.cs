
using _05_Prototype.models;

var s1 = new Student
{
    Id = 1,
    Name = "Ali",
    Birthday = new DateTime(1987, 02, 18),
    Lessons = new List<string> { "Math" }
};
Console.WriteLine($"Id: {s1.Id}, Name: {s1.Name}, Birthday: {s1.Birthday}, Lessons: {string.Join(',', s1.Lessons.ToArray())}");

var shallowS1 = s1.ShallowCopy();
Console.WriteLine($"Id: {shallowS1.Id}, Name: {shallowS1.Name}, Birthday: {shallowS1.Birthday}, Lessons: {string.Join(',', shallowS1.Lessons.ToArray())}");

var deepCopyS1 = s1.DeepCopy();
Console.WriteLine($"Id: {deepCopyS1.Id}, Name: {deepCopyS1.Name}, Birthday: {deepCopyS1.Birthday}, Lessons: {string.Join(',', deepCopyS1.Lessons.ToArray())}");

Console.WriteLine("*************************");
s1.Id = 2;
s1.Name = "Ayşe";
s1.Birthday = new DateTime(1990,02,02);
s1.Lessons.Add("Geo");

Console.WriteLine($"Id: {s1.Id}, Name: {s1.Name}, Birthday: {s1.Birthday}, Lessons: {string.Join(',', s1.Lessons.ToArray())}");
Console.WriteLine($"Id: {shallowS1.Id}, Name: {shallowS1.Name}, Birthday: {shallowS1.Birthday}, Lessons: {string.Join(',', shallowS1.Lessons.ToArray())}");
Console.WriteLine($"Id: {deepCopyS1.Id}, Name: {deepCopyS1.Name}, Birthday: {deepCopyS1.Birthday}, Lessons: {string.Join(',', deepCopyS1.Lessons.ToArray())}");




