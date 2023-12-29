using System.Collections;

ArrayList arrayList = new ArrayList();
arrayList.Add(100);
arrayList.Add(200);
arrayList.Add(300);
arrayList.Add(400);
arrayList.Add(500);
Console.WriteLine("capacity of arraylist = "+arrayList.Capacity);

Console.WriteLine("After insertion");
arrayList.Insert(3,350);
foreach(object obj in arrayList)
    Console.Write(obj+" ");
Console.WriteLine();
Console.WriteLine("After deletion");
//arrayList.RemoveAt(1);
arrayList.Remove(200);
foreach(object obj in arrayList)
    Console.Write(obj+" ");
Console.ReadLine(); 

