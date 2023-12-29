using System;
using System.Collections.Generic;

class Program
{
    static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // Example with List<T>
        List<int> list = new List<int> { 1, 2, 3, 4, 5 };
        PrintCollection(list);

        // Example with array
        int[] array = { 6, 7, 8, 9, 10 };
        PrintCollection(array);

        // Example with HashSet<T>
        HashSet<int> hashSet = new HashSet<int> { 11, 12, 13, 14, 15 };
        PrintCollection(hashSet);
    }
}
