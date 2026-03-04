using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using curso_csharp.Entities;

class Program
{
    public static void Main(string[] args)
    {
        HashSet<LogStudents> studentNum = new HashSet<LogStudents>();

        Console.Write("How many students for course A? ");
        int courseA = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= courseA; i++)
        {
            studentNum.Add(new LogStudents { StudentNumber = int.Parse(Console.ReadLine()!) });
        }

        Console.Write("How many students for course B? ");
        int courseB = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= courseB; i++)
        {
            studentNum.Add(new LogStudents { StudentNumber = int.Parse(Console.ReadLine()!) });
        }

        Console.Write("How many students for course C? ");
        int courseC = int.Parse(Console.ReadLine()!);
        for (int i = 1; i <= courseC; i++)
        {
            studentNum.Add(new LogStudents { StudentNumber = int.Parse(Console.ReadLine()!) });
        }

        Console.WriteLine($"Total students: {studentNum.Count}");
    }
}