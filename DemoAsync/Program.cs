using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        await DemoText();
    }

    static async Task DemoText()
    {
        Console.WriteLine("1. This is a demo example");

        try
        {
            string text = await ReadFileAsync("demo.txt");
            Console.WriteLine($"2. Read content: {text}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("2. File not found.");
        }
    }

    static async Task<string> ReadFileAsync(string fileName)
    {
        return await File.ReadAllTextAsync(fileName);
    }
}
