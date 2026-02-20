using DotNetEnv;

class Program
{
    public static void Main(string[] args)
    {
        Env.Load();

        string sourcePath = Path.Combine(Environment.GetEnvironmentVariable("DIR_PATH")!, "file1.txt");
        string targetPath = Path.Combine(Environment.GetEnvironmentVariable("DIR_PATH")!, "file2.txt");

        try 
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            throw;
        }
    }
}