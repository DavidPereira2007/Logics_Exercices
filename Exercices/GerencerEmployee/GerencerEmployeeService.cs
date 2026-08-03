////////////////////////////////////////
/// by: David de Sousa Pereira 03/08/2026
/// Code: Service Application
////////////////////////////////////////

namespace GerencerEmployee;

using System;

public static class GerencerEmployeeService
{
    public static List<Employee> Employees = new List<Employee>();


    public static void Create_Employee(string name, decimal salary)
    {
        Employee employee = new Employee();
        employee.Create_Employee(name, salary);
        Employees.Add(employee);
    }

    public static void List_Employees()
    {
        if (Employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        foreach (var employee in Employees)
        {
            employee.Write_Employee();
            Console.WriteLine("--------------------");
        }
    }

    public static void Increase_Salary(int employeeId, decimal percentage)
    {
        Employee? employee = Employees.Find(e => e.Employee_Id() == employeeId);

        if (employee != null)
        {
            employee.increases_Salary(percentage);
            Console.WriteLine($"Salary of Employee {employeeId} increased by {percentage}%.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
            List_Employees();
        }
    }

    public static void Deduct_Salary(int employeeId, decimal percentage)
    {
        Employee? employee = Employees.Find(e => e.Employee_Id() == employeeId);

        if (employee != null)
        {
            employee.deductions_Salary(percentage);
            Console.WriteLine($"Salary of Employee {employeeId} deducted by {percentage}%.");
        }
        else
        {
            Console.WriteLine("Employee not found.");
            List_Employees();
        }
    }

    public static void Calculate_NetPay(int employeeId)
    {
        Employee? employee = Employees.Find(e => e.Employee_Id() == employeeId);

        if (employee != null)
        {
            employee.NetPay_Salary();
        }
        else
        {
            Console.WriteLine("Employee not found.");
            List_Employees();
        }
    }
}