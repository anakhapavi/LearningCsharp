while(true)
{
    System.Console.WriteLine("Enter operation(Concat,Length,Remove,Sort; type exit to quit):");
    string userOperation = Console.ReadLine();

    if(userOperation.ToLower() == "exit")
        break;

    System.Console.WriteLine("Enter a string");
    string userInput = Console.ReadLine();

    var userStringOperations = new StringOperations{Operations=userOperation,Input=userInput};
    string result = StringFunctions.ExecuteStringFunctions(userStringOperations);
    Console.WriteLine(result);


}