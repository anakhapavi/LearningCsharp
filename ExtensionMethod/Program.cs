class Program
{
    public void Method1()
    {
        System.Console.WriteLine("method 1");
    }
    public void Method2()
    {
        System.Console.WriteLine("method 2");
    }
    static void Main()
    {
        Program p = new Program();
        p.Method1();
        p.Method2();
    }
}