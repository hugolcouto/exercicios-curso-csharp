using DotNetEnv;

class Program
{
    public static void Main(string[] args)
    {
        Env.Load();

        string path = Path.Combine(Environment.GetEnvironmentVariable("DIR_PATH")!, "file1.txt");

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine()!;
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }


    }
}