using System.Xml;
using DotNetEnv;

class Program
{
    public static void Main(string[] args)
    {
        Env.Load();

        string path = Path.Combine(Environment.GetEnvironmentVariable("DIR_PATH")!, "file1.txt");

        StreamReader sr = null!;

        try
        {
            sr = File.OpenText(path);

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine()!;
                Console.WriteLine(line);
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            throw;
        }
        finally
        {
            if (sr != null) sr.Close();
        }
    }
}