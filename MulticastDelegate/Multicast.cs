public delegate void myDelegate(string message);
public class Multicast
{
    public void Method1(string message)
    {
        Console.WriteLine($"{message}");
    }
    public void Method2(string message)
    {
        Console.WriteLine($"{message}");
    }
}