Calculator calc = new Calculator();
Operations add = new Operations(calc.Addition);
Operations sub = new Operations(calc.Subtraction);
Operations mult = new Operations(calc.Multiplication);
Operations div = new Operations(calc.Division);

int res1 = add(10,5);
int res2 = sub(10,5);
int res3 = mult(10,5);
int res4 = div(10,5);

Console.WriteLine($"+ {res1}");
Console.WriteLine($"- {res2}");
Console.WriteLine($"* {res3}");
Console.WriteLine($"/ {res4}");