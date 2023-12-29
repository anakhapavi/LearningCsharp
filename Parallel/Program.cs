var myList = new List<int> {1,5,6,8,9,10,2,3,4};
Parallel.ForEach(myList,(i)=>System.Console.WriteLine(i));
System.Console.WriteLine("-----------------------------------");
Parallel.For(1,10,(i)=>System.Console.WriteLine(i));