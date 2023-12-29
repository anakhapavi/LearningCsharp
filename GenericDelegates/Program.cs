// Func<T> delegate
Func<int,float,int> multiply = (x,y) => (int) (x*y);

// Action<T,TResult> delegate
Action<int,float> product = (a,b) =>
{
    int result = multiply(a,b);
    Console.WriteLine($"Action<T,TResult> : {result}");
};

// Predicate<T> delegate
Predicate<string> message = str => 
{
    if(str.Length > 5)
        return true;
    return false;
};
//usage
int num1 = 5;
float num2 = 2.5f;
int res = multiply(num1,num2);
Console.WriteLine($"Func<T> : {res}");
product(num1,num2);

string msg ="hello!";
bool result = message(msg);
Console.WriteLine($"Predicate<T> : {result}");
