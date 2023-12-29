int[] numbers = Enumerable.Range(1,20).ToArray();
//Regular LINQ
var query = from num in numbers 
            where num%2 == 0
            select num;
System.Console.WriteLine("Regualr LIN query");
foreach(var num in query)
    System.Console.WriteLine(num);

//PLINQ
var parallelQuery = from num in numbers.AsParallel().AsOrdered()
                    where num%2 == 0
                    select num;
System.Console.WriteLine("PLINQ query");
foreach(var item in parallelQuery)
    System.Console.WriteLine(item);

//PLINQ with WithDegreeOfParallelism
var query2 = numbers.AsParallel()
             .WithDegreeOfParallelism(3)
             .Where(num=> num%2 == 0)
             .Select(num=> num);
System.Console.WriteLine("PLINQ - WithDegreeOfParallelism");
foreach(var item in query2)
    System.Console.WriteLine(item);