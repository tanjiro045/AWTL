using System;
public class Salary
{
public double Basic { get; set; }
public double TA { get; set; }
public double DA { get; set; }
public double HRA { get; set; }
// Constructor with default values for DA and HRA
public Salary(double basic, double ta)
{
Basic = basic;
TA = ta;
DA = 0.5 * basic; // Default DA is 50% of Basic
HRA = 0.25 * basic; // Default HRA is 25% of Basic
}
// Method to calculate total salary of employee
public double CalculateSalary()
{
return Basic + TA + DA + HRA;
}
}
// Example usage
public class Program
{
public static void Main()
{
// Create a new instance of the Salary class
Console.WriteLine("Enter Basic Salary: ");
  double basicSalary = double.Parse(Console.ReadLine());
Console.WriteLine("Enter TA: ");
double taSalary = double.Parse(Console.ReadLine());
Salary employeeSalary = new Salary(basicSalary, taSalary);
// Calculate the total salary of the employee
double totalSalary = employeeSalary.CalculateSalary();
// Print the total salary
Console.WriteLine("Total salary of employee: {0}", totalSalary);
Console.ReadLine();
}
}
