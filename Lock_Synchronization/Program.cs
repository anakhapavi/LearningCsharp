class SharedReasource
{
    static int sharedCounter=0;
    static object lockObject = new object();

    static void Main()
    {
        Thread t1 = new Thread(lockMethod);
        Thread t2 = new Thread(lockMethod);
        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        System.Console.WriteLine($"Shared counter = {sharedCounter}");
        Console.ReadLine();
    }
    static void lockMethod()
    {
        for(int i=0; i<10000; i++)
        {
            lock(lockObject)
            {
                sharedCounter++;
            }
        }
    }
}