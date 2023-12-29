using System;
using System.Collections.Generic;

class Calculator<T>
{
    public void Add(T a, T b)
    {
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 + d2);
    }
    public void Sub(T a,T b)
    {
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 - d2);
    }
    public void Mult(T a,T b)
    {
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 * d2);
    }
    public void Div(T a,T b)
    {
        dynamic d1 = a;
        dynamic d2 = b;
        Console.WriteLine(d1 / d2);
    }
}
class  GenericCollection
{
    static void Main(string[] args)
    {
        Calculator<int> obj = new Calculator<int>();
        obj.Add(10,20);
        obj.Sub(20,10);
        obj.Mult(10,20);
        obj.Div(20,10);
        Console.ReadLine();

    }
}