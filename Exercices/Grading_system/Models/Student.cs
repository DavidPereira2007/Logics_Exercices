////////////////////////////////////////
/// by: David de Sousa Pereira 09/08/2026
/// Code: Model for use in the application
////////////////////////////////////////


namespace Grading.Models;
using Grading.Models;

public class Student
{
    public int Id {get; set;}
    public string? Name {get; set; }
    public List<Grade> Grades = [];


    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void AddGrade(Grade grade)
    {
        Grades.Add(grade);
    }

    public void RemoveGrade(Grade grade)
    {
        Grades.Remove(grade);
    }

    public void ViewGrades()
    {
        foreach (var grade in Grades)
        {
            Console.WriteLine($"Grade ID: {grade.Id}, Name: {grade.Name}, Value: {grade.Value}");
        }
    }
}
