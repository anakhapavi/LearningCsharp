Database db = new Database();
IdGenertor id = new IdGenertor();
EmailGenerator eg = new EmailGenerator();

//subscribe this classes to UserProcessorEvent
UserProcessor.UserProcessorEvent += db.saveToDB;
UserProcessor.UserProcessorEvent += id.IdCard;
UserProcessor.UserProcessorEvent += eg.Email;

Console.WriteLine("commands accepted");
Console.WriteLine("1. new: Add new user");
Console.WriteLine("2. exit: Exit from application");
while(true)
{
    Console.WriteLine("Enter command ");
    var cmdInput = Console.ReadLine();

    if(cmdInput.Equals("exit"))
        break;
    else if(cmdInput.Equals("new"))
    {
            Console.Write("Enter Name : ");
            var name = Console.ReadLine();
            Console.Write("Enter Age : ");
            var age = int.Parse(Console.ReadLine());

            UserProcessor.ProcessUser(name,age);
    }
    else    
        Console.Write("Invalid");

}
