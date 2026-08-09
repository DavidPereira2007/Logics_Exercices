////////////////////////////////////////
/// by: David de Sousa Pereira 09/08/2026
/// Code: Model for use in the application
////////////////////////////////////////


namespace Grading.Models;

public class Grade
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Value { get; set; }

    public Grade(int id, string name, double value)
    {
        Id = id;
        Name = name;
        Value = value;
    }

    public void EditGrade(string name, double value)
    {
        Name = name;
        Value = value;
    }
}