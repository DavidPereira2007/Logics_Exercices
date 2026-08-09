////////////////////////////////////////
/// by: David de Sousa Pereira 09/08/2026
/// Code: Interface for use in the application
////////////////////////////////////////


namespace Grading.Presentation;
using Grading.Models;
using Grading.Services;


public static class GradingProgram
{

    private static void Clear_Console()
    {
        Console.Clear();

        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Create Student");
        Console.WriteLine("2. Add Grade to Student");
        Console.WriteLine("3. Calculate Average for Student");
        Console.WriteLine("4. View Students");
        Console.WriteLine("5. View Grades for Student");
        Console.WriteLine("6. Edit Grade for Student");
        Console.WriteLine("7. Exit");
    }

    private static Student SearchStudentById(List<Student> students)
    {
        Clear_Console();
        Console.Write("Enter student ID to add grade: ");
        var studentIdInput = Console.ReadLine()!;

        if (!int.TryParse(studentIdInput, out int studentId))
        {
            //Console.WriteLine("Invalid ID. Please enter a valid number.");
            throw new Exception("Invalid ID. Please enter a valid number.");
        }

        Student? student = students.Find(s => s.Id == studentId);
        if (student == null)
        {
            //Console.WriteLine($"Student with ID {studentId} not found.");
            throw new Exception($"Student with ID {studentId} not found.");
        }
        return student;
    }

    private static void CreateStudent(List<Student> students)
    {
        Clear_Console();
        Console.Write("Enter student ID: ");
        var id = Console.ReadLine()!;

        Console.Write("Enter student name: ");
        string name = Console.ReadLine()!;

        if (!int.TryParse(id, out int studentId))
        {
            Console.WriteLine("Invalid ID. Please enter a valid number.");
            return;
        }

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Student name cannot be empty.");
            return;
        }

        Clear_Console();
        Student student = GradingService.CreateStudent(studentId, name);
        students.Add(student);
        Console.WriteLine($"Student created successfully | ID: {studentId}, Name: {name}");
    }

    private static void AddGradeToStudent(Student student)
    {
        Clear_Console();
        Console.Write("Enter grade ID: ");
        var gradeIdInput = Console.ReadLine()!;

        Console.Write("Enter grade name: ");
        string gradeName = Console.ReadLine()!;

        Console.Write("Enter grade value: ");
        var gradeValueInput = Console.ReadLine()!;

        if (!int.TryParse(gradeIdInput, out int gradeId))
        {
            Console.WriteLine("Invalid grade ID. Please enter a valid number.");
            return;
        }

        if (!double.TryParse(gradeValueInput, out double gradeValue))
        {
            Console.WriteLine("Invalid grade value. Please enter a valid number.");
            return;
        }

        if (string.IsNullOrWhiteSpace(gradeName))
        {
            Console.WriteLine("Grade name cannot be empty.");
            return;
        }

        Clear_Console();
        Grade grade = new Grade(gradeId, gradeName, gradeValue);
        GradingService.AddGradeToStudent(student, grade);
        Console.WriteLine($"Grade added successfully | ID: {gradeId}, Name: {gradeName}, Value: {gradeValue}");
    }

    private static void CalculateAverageForStudent(Student student)
    {
        Clear_Console();
        double average = GradingService.CalculateAverage(student);
        string finalGrade = GradingService.DetermineFinalGrade(student);

        Console.WriteLine($"Average for student {student.Name}: {average}");
        Console.WriteLine($"Final Grade: {finalGrade}");
    }

    private static void ViewStudents(List<Student> students)
    {
        Clear_Console();
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        Console.WriteLine("List of Students:");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
        }
    }

    private static void ViewGradesForStudent(Student student)
    {
        Clear_Console();
        if (student.Grades.Count == 0)
        {
            Console.WriteLine($"No grades available for student {student.Name}.");
            return;
        }

        Console.WriteLine($"Grades for student {student.Name}:");
        foreach (var grade in student.Grades)
        {
            Console.WriteLine($"Grade ID: {grade.Id}, Name: {grade.Name}, Value: {grade.Value}");
        }
    }

    private static void Edit_Grade(Student student)
    {
        Console.Write("Enter grade ID: ");
        var gradeIdInput = Console.ReadLine()!;

        if (!int.TryParse(gradeIdInput, out int gradeId))
        {
            Console.WriteLine("Invalid grade ID. Please enter a valid number.");
            return;
        }

        Grade? grade = student.Grades.Find(g => g.Id == gradeId);
        if (grade == null)
        {
            Console.WriteLine($"Grade with ID {gradeId} not found for student {student.Name}.");
            return;
        }

        Console.Write("Edit grade name or press Enter to keep current: ");
        string gradeName = Console.ReadLine()!;

        Console.Write("Edit grade value or press Enter to keep current: ");
        var gradeValueInput = Console.ReadLine()!;

        if (!string.IsNullOrWhiteSpace(gradeName))
        {
            grade.Name = gradeName;
        }

        if (!string.IsNullOrWhiteSpace(gradeValueInput))
        {
            if (double.TryParse(gradeValueInput, out double gradeValue))
            {
                grade.Value = gradeValue;
            }
            else
            {
                Console.WriteLine("Invalid grade value. Please enter a valid number.");
                return;
            }
        }

        Console.WriteLine($"Grade updated successfully | ID: {grade.Id}, Name: {grade.Name}, Value: {grade.Value}");

    }
    public static void init()
    {
        Console.WriteLine("Welcome to the Grading System");
        List<Student> students = new List<Student>();

        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Create Student");
        Console.WriteLine("2. Add Grade to Student");
        Console.WriteLine("3. Calculate Average for Student");
        Console.WriteLine("4. View Students");
        Console.WriteLine("5. View Grades for Student");
        Console.WriteLine("6. Edit Grade for Student");
        Console.WriteLine("7. Exit");

        while(true)
        {

            Console.WriteLine("Enter your choice: ");
            string choice = Console.ReadLine()!;

            switch(choice)
            {
                case "1":
                    CreateStudent(students);
                    break;
                case "2":
                    // search and Add Grade to Student
                    Student student = SearchStudentById(students);
                    AddGradeToStudent(student);
                    break;
                case "3":
                    // search and Calculate Average for Student
                    Student studentForAverage = SearchStudentById(students);
                    CalculateAverageForStudent(studentForAverage);
                    break;
                case "4":
                    // View Students
                    ViewStudents(students);
                    break;
                case "5":
                    // View Grades for Student
                    Student studentForGrades = SearchStudentById(students);
                    ViewGradesForStudent(studentForGrades);
                    break;
                case "6":
                    // Edit Grade for Student
                    Student studentForEdit = SearchStudentById(students);
                    Edit_Grade(studentForEdit);
                    break;
                case "7":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}