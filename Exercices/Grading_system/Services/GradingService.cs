////////////////////////////////////////
/// by: David de Sousa Pereira 09/08/2026
/// Code: Service for use in the application
////////////////////////////////////////


namespace Grading.Services;
using Grading.Models;

public static class GradingService
{
    public static Student CreateStudent(int id, string name)
    {
        Student student = new Student(id, name);
        return student;
    }
    
    public static void AddGradeToStudent(Student student, Grade grade)
    {
        student.AddGrade(grade);
    }

    public static double CalculateAverage(Student student)
    {
        if (student.Grades.Count == 0)
        {
            return 0;
        }

        double total = 0;
        foreach (var grade in student.Grades)
        {
            total += grade.Value;
        }

        return total / student.Grades.Count;
    }

    public static string DetermineFinalGrade(Student student)
    {
        double average = CalculateAverage(student);

        switch (average)
        {
            case var _ when average >= 70:
                return "Aproved";
            case var _ when average >= 40:
                return "Recovery";
            default:
                return "Failed";
        }
    }
}