public class Teacher
{
    public  event EventHandler<Details> TeacherInfoEvent;
    public  void TeacherInfo(string name,string subject)
    {
        Details ds = new Details();
        ds.Name = name;
        ds.Subject = subject;
        TeacherInfoEvent?.Invoke(this,ds);
    }
}