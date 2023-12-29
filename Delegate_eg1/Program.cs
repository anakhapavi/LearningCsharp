public delegate void MyDelegate(string message);
public class Program
{
    public static void Main()
    {
        MyDelegate d1 = DisplayMessage;
        d1("Hello, delegates!");
    }

    public static void DisplayMessage(string message)
    {
        Console.WriteLine($"Message: {message}");
    }
}
