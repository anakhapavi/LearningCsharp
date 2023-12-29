class Program
{
static async Task Main()
{
    using(CancellationTokenSource cts = new CancellationTokenSource())
    {
        CancellationToken token = cts.Token;
        //start a task which takes long-run time
        Task task = MethodCancellation(token);
        System.Console.WriteLine("Press any key to cancel the operation");
        Console.ReadKey();
        cts.Cancel();
        try
        {
            await task;
        }
        catch(OperationCanceledException)
        {
            System.Console.WriteLine("Operation cancelled");
        }
    }
}
static async Task MethodCancellation(CancellationToken cancellationToken)
{
    try
    {
        for(int i=0; i<1000; i++)
        {
            await Task.Delay(100);
            cancellationToken.ThrowIfCancellationRequested();
            System.Console.WriteLine($"Iteration{i}");
        }
    }
    catch(OperationCanceledException)
    {
        System.Console.WriteLine("Operation cancelld");
    }

}
}