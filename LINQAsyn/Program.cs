using System;
using System.Collections.Generic;
using System.LINQ;
class Program
{
    static void Main()
    {
         List<int> numbers = new List<int> {5,2,8,3,7,1,6,4};
         //sort numbers using LINQ
         var sortNumbers = numbers.OrderBY(n => n).ToList();
         //sorted numbers separted as odd and even numbers
         var oddNumbers = sortNumbers.Where(n => n%2!=0).ToList();
         var evenNumbers = sortNumbers.Where(n => n%2 == 0).ToList();

         System.Console.Write("sorted numbers: ");
         Display(sortNumbers);
         System.Console.WriteLine("odd numbers: ");
         Display(oddNumbers);
         System.Console.WriteLine("even number: ");
         Display(evenNumbers);
    }
    static void Display(List<int> numbers)
    {
        foreach(var num in numbers)
         {
            System.Console.WriteLine($"{num}{" "}");
        }
    }
}