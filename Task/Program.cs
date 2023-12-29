static void Method1(int id, int sleepTime)
{
    System.Console.WriteLine("Task {0} is beggining",id);
    Thread.Sleep(sleepTime);
    System.Console.WriteLine("Task {0} is completed",id);
}
static void Method2(int id, int sleepTime)
{
    System.Console.WriteLine("Task {0} is beggining",id);
    Thread.Sleep(sleepTime);
    System.Console.WriteLine("Task {0} is completed",id);
}
var t1 = new Task(()=>Method1(1,1500));
/*
t1.Start();
var t2 = new Task(()=>Method1(2,3000));
t2.Start();
*/

//Task.Factory.StartNew
var t3 = Task.Factory.StartNew(()=>Method1(3,1000)).ContinueWith((prevTask)=>Method2(1,1000));
//Task.WaitAll(t2,t1);


System.Console.WriteLine("Press any key to quit");
Console.ReadKey();
