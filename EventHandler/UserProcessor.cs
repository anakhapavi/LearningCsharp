public class UserProcessor
{
    public static event EventHandler<UserArgs> UserProcessorEvent;
    public static void ProcessUser(string name,int age)
    {
        UserArgs args = new UserArgs();
        args.Name = name;
        args.Age = age;

        UserProcessorEvent?.Invoke(null,args);
    }
}
