// Define an Employee class 
public class Employee
{
    // Employee propierties
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }

    // Constructor 
    public Employee(string name, int age, decimal salary)
    {
        Name = name
        Age = age;
        Salary = salary;
    }

    // Display employee information
    public void DisplayInfo()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Age: {Age}");
        System.Console.WriteLine($"Salary: ${Salary}");
    }
}