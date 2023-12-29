MyClass obj = new MyClass();
myDelegate d1 = new myDelegate(obj.oddNumber);
myDelegate d2 = new myDelegate(obj.evenNumbers);

Console.WriteLine("Odd numbers");
//invoke
d1(1);
d1(3);
d1(5);
Console.WriteLine();
Console.WriteLine("Even numbers");
d2(2);
d2(4);