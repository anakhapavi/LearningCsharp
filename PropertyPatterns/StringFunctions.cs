using System.Security.Cryptography;

public class StringFunctions
{
    public static string ExecuteStringFunctions(StringOperations operations)
    {
        return operations switch
        {
            {Operations:"Concat",Input:var input} => ConcatString(input),
            {Operations:"Length",Input:var input} => StringLength(input),
            {Operations:"Remove",Input:var input} => RemoveCharacters(input),
            {Operations:"Sort",Input:var input} => StringSort(input),
            _ => "Invalid string or operations"
        };
    }
    private static string ConcatString(string input)
    {
        return $"Concatinated: {input + input}";
    }
    private static string StringLength(string input)
    {
        return $"String Length: {input.Length}";
    }
    private static string RemoveCharacters(string input)
    {
        int indexToRemove = input.Length/2;
        return $"Remove: {input.Remove(indexToRemove)}";
    }
    private static string StringSort(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Sort(charArray);
        return $"Sorted:{new string(charArray)}";
    }
}