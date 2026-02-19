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
            FileInfo fileInfo = new FileInfo(sourcePath);
            FileInfo fileInfo2 = new FileInfo(targetPath);

            if (fileInfo2.Exists)
            {
                fileInfo2.Delete();
            }

            fileInfo.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Success!");
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            throw;
        }
    }
}