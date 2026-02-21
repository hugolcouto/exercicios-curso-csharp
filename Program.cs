using System.Globalization;
using DotNetEnv;
using Microsoft.Extensions.Primitives;

class Program
{
    public static void Main(string[] args)
    {
        Env.Load();
        string srcPath = $"{Environment.GetEnvironmentVariable("DIR_PATH")!}/data/src";
        string outputPath = $"{Environment.GetEnvironmentVariable("DIR_PATH")!}/data/out";
        string sourceFile = Path.Combine(srcPath, "sales.csv");
        string outputFile = Path.Combine(outputPath, "summary.csv");

        try
        {
            string[] lines = File.ReadAllLines(sourceFile);

            if (!Directory.Exists(outputPath))
            {
                Directory.CreateDirectory(outputPath);
            }

            if (File.Exists(outputFile))
            {
                string[] files = Directory.GetFiles(outputPath);
                Array.ForEach(files, File.Delete);
            }

            using (StreamWriter sw = File.AppendText(outputFile))
            {
                foreach (string line in lines)
                {
                    string[] l = line.Split(',');
                    l[1] = (float.Parse(l[1], CultureInfo.InvariantCulture.NumberFormat) * int.Parse(l[2])).ToString("F2", CultureInfo.InvariantCulture);
                    sw.WriteLine($"{l[0]},{l[1]}");
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