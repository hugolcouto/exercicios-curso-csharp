class Program
{
    public static void Main(string[] args)
    {
        string sourcePath = @"/Users/hugolcouto/Estudos/udemy/primeiro-semestre/dotnet/curso-csharp/file1.txt";
        string targetPath = @"/Users/hugolcouto/Estudos/udemy/primeiro-semestre/dotnet/curso-csharp/file2.txt";

        try
        {
            FileInfo fileInfo = new FileInfo(sourcePath);
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