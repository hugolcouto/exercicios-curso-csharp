using DotNetEnv;

class Program
{
    public static void Main(string[] args)
    {
        Env.Load();

        string path = Path.Combine(Environment.GetEnvironmentVariable("DIR_PATH")!, "myFolder");

        try
        {

            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
            }

            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Directory.CreateDirectory(Path.Combine(path, "new_directory"));
        }
        catch (IOException e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
            throw;
        }
    }
}