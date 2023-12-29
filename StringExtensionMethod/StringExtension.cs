public static class StringExtension
{
    public static string Capitalize(this string input)
    {
        if(string.IsNullOrEmpty(input))
        {
            return input;
        }
        return char.ToUpper(input[0])+input.Substring(1);
    }
    
}