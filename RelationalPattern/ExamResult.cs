using System.Security.Cryptography;

public class ExamResult
{
    public static string AnalyzeResult(Student student)
    {
        return student.Mark switch
        {
            < 0 => $"{student.Name}'s score is negative",
            >=0 and <= 15 =>$" {student.Name} is failed",
            >=15 and <=25 =>$"{student.Name} is average",
            >=25 and <=40 => $"{student.Name} score is good",
            >=40 =>$"{student.Name} is excellent",
        };
    }
}