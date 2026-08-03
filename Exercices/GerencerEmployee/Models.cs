////////////////////////////////////////
/// by: David de Sousa Pereira 03/08/2026
/// Code: Models for use em Application
////////////////////////////////////////

namespace GerencerEmployee;

using System;

public class Employee
{
    private int id;
    private string? name;
    private decimal salary;

    public void Create_Employee(string NewName, decimal NewSalary)
    {
        id = IdGenerator.GerarProximoId();
        name = NewName;
        salary = NewSalary;
    }

    public void Write_Employee()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Salary: {salary}");
    }

    public int Employee_Id()
    {
        return id;
    }

    public void increases_Salary(decimal percentage)
    {
        salary += salary * percentage / 100;
    }

    public void deductions_Salary(decimal percentage)
    {
        salary -= salary * percentage / 100;
    }

    public void NetPay_Salary()
    {
        // net pay calculation logic can be implemented here based on the salary and deductions
        decimal taxRate = 0.1m; // Example tax rate of 10%
        decimal Benefits = 0.04m; // Example benefits rate of 4%
        decimal INSS = 0.08m; // Example INSS rate of 8%

        decimal deductions = salary * (taxRate + Benefits + INSS);
        decimal netPay = salary - deductions;
        Console.WriteLine($"Net Pay: {netPay}");
    }
}