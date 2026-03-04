using System.Runtime.CompilerServices;
using curso_csharp.Entities;
using DotNetEnv;

class Program
{
    public static void Main(string[] args)
    {
        Env.Load();

        string filePath = Path.Combine($"{Environment.GetEnvironmentVariable("DIR_PATH")!}/Data", "log.txt");

        HashSet<LogRecord> set = new HashSet<LogRecord>();


        try
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                while (!sr.EndOfStream)
                {
                    string[] line = sr.ReadLine()!.Split(' ');
                    string name = line[0];
                    DateTime instant = DateTime.Parse(line[1]);
                    set.Add(new LogRecord { UserName = name, Instant = instant });
                }

                Console.WriteLine($"Log file path: {filePath}\nTotal users: {set.Count}");
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}