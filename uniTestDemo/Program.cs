class Program
{
    static void Main()
    {
         int c = Add(2,3);
         System.Console.WriteLine(c);
         System.Console.WriteLine(isOdd(7));
    }

    public static int Add(int a, int b)
    {
        return a+b;
    }
    public static bool isOdd(int value)
    {
        return value%2 == 1;
    }
}