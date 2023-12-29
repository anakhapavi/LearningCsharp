using System.Collections.Concurrent;
class Program
{
static void Main()
{
    ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();
    Parallel.Invoke(
        () => AddItems(concurrentBag,1,5),
        () => AddItems(concurrentBag,6,10),
        () => AddItems(concurrentBag,11,15)
    );
    System.Console.WriteLine("Items in ConcurrentBag");
    foreach(var item in concurrentBag)
    {
        System.Console.WriteLine(item);
    }
}
static void AddItems(ConcurrentBag<int> bag,int start,int end)
{
    for(int i=start; i<=end; i++)
    {
        System.Console.WriteLine(i);
    }

}
}