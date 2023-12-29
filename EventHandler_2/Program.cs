
Console.WriteLine("Enter Name: ");
var name = Console.ReadLine();
Console.WriteLine("Enter Subject: ");
var subject = Console.ReadLine();

Teacher teacherInstance = new Teacher();
FirstPeriod fp = new FirstPeriod();
teacherInstance.TeacherInfoEvent += fp.MorningShiht;
teacherInstance.TeacherInfo(name, subject);

