class Program
{
    public delegate int sumDelegate(int x,int y);
    static void Main(string[] args) 
    {
        sumDelegate d1 = delegate(int x,int y) {return x+y;};
        Console.WriteLine(d1(100,200));
    }
}