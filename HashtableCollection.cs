using System.Collections;

namespace Collection_demo1;

public class HastableCollection
{
    private static void Main(String[] args)
    {
        
        Hashtable hashtable = new Hashtable();
        hashtable.Add("eNo",1010);
        hashtable.Add("eName","anakha");
        //Console.WriteLine(hashtable["eName"];
        //Console.WriteLine("anakha".GetHashCode());
        foreach(object key in hashtable.Keys)
            Console.WriteLine(hashtable+":"+hashtable[key]);
        Console.ReadLine();

    }
}

