Index  start =0;
Index end = 5;
Range range = start..end;

int[] numbers = new []{0,1,2,3,4,5,6,7,8,9};
int[] slice = numbers[..2];
foreach(var element in slice)
    System.Console.WriteLine(element);

//Hat operator
int[] slice2 = numbers[..^1];
System.Console.Write("using hat opertor => ");
foreach(var element in slice)
    System.Console.Write($"{element}{" "}");

System.Console.WriteLine();
//substring using range
var name = "Advanced c#";
var substring = name[5..];
System.Console.WriteLine($"substring => {substring}");