

class InterlockedExample
{
    static int sharedCounter;
    static void Main()
    {
        Thread t1 = new Thread(InterlockedIncreament);
        Thread t2 = new Thread(InterlockedIncreament);
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        System.Console.WriteLine($"shared counter{sharedCounter}");
        Console.ReadLine();
    }
    static void InterlockedIncreament()
    {
        for(int i=0; i<10000; i++)
        {
            Interlocked.Increment(ref sharedCounter);

        }
    }
}