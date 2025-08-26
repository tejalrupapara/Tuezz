using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Employee
{
    // Properties
    public string EmployeeCode { get; set; }
    public string Name { get; set; }
    public string Designation { get; set; }
    public string InstName { get; set; }
    public double BasicPay { get; set; }
    public double HRA { get; private set; }
    public double DA { get; private set; }
    public double TotalPay { get; private set; }

    // Static field to track employee with highest pay
    private static Employee employeeWithHighestPay = null;

    // Constructor
    public Employee(string empCode, string name, string designation, string instName, double basicPay)
    {
        EmployeeCode = empCode;
        Name = name;
        Designation = designation;
        InstName = instName;
        BasicPay = basicPay;
    }

    // Method to calculate allowances and total pay
    public void CalculatePay()
    {
        HRA = BasicPay * 0.10;      // 10% of basic pay
        DA = BasicPay * 0.45;       // 45% of basic pay
        TotalPay = BasicPay + HRA + DA;

        // Update employee with highest pay
        if (employeeWithHighestPay == null || TotalPay > employeeWithHighestPay.TotalPay)
        {
            employeeWithHighestPay = this;
        }
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine($"Code: {EmployeeCode}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Designation: {Designation}");
        Console.WriteLine($"Institution: {InstName}");
        Console.WriteLine($"Basic Pay: {BasicPay:C}");
        Console.WriteLine($"HRA (10%): {HRA:C}");
        Console.WriteLine($"DA (45%): {DA:C}");
        Console.WriteLine($"Total Pay: {TotalPay:C}");
    }

    // Static method to get employee with highest pay
    public static Employee GetEmployeeWithHighestPay()
    {
        return employeeWithHighestPay;
    }
}

class Program
{
    static void Main()
    {
        // Create first employee
        Employee emp1 = new Employee("E001", "John Doe", "Manager", "Tech Corp", 50000);
        emp1.CalculatePay();
        emp1.DisplayDetails();

        // Create second employee
        Employee emp2 = new Employee("E002", "Jane Smith", "Developer", "Tech Corp", 45000);
        emp2.CalculatePay();
        emp2.DisplayDetails();

        // Display employee with highest total pay
        Employee highestPaid = Employee.GetEmployeeWithHighestPay();
        Console.WriteLine("\n=== EMPLOYEE WITH HIGHEST TOTAL PAY ===");
        highestPaid.DisplayDetails();
    }
}