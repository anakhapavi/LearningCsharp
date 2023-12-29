using System;
using System.Collections.Generic;
class GenericCollection
{    public bool Compare<T>(T a, T b)
    {
        if(a.Equals(b))
            return true;
        return false;
    }
    static void Main(string[] args)
    {
        GenericCollection obj = new GenericCollection();
        bool result1 = obj.Compare<int>(10,10);
        bool result2 = obj.Compare<string>("anakha","anu");
        Console.WriteLine("int => "+result1);
        Console.WriteLine("string => "+result2);
        Console.ReadLine();
    }
}