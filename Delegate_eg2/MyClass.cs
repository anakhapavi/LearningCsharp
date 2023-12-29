public delegate void myDelegate(int number);
public class MyClass
{
    public void oddNumber(int number)
    {
        Console.Write($"{number},");
    }
    public void evenNumbers(int number)
    {
        Console.Write($"{number},");
    }
}