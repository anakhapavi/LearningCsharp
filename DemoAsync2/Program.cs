using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Start of Main method");

        // Start asynchronous operation to fetch data from a web service
        string data = await FetchDataAsync();

        // Continue with other tasks while waiting for FetchDataAsync to complete
        Console.WriteLine($"Fetched data: {data}");

        Console.WriteLine("End of Main method");
    }

    static async Task<string> FetchDataAsync()
    {
        Console.WriteLine("Start fetching data from web service");

        // Simulate an asynchronous operation, such as fetching data from a web service
        await Task.Delay(2000);

        // Simulated data fetched from the web service
        string simulatedData = "This is the data from the web service.";

        Console.WriteLine("End fetching data from web service");

        return simulatedData;
    }
}
