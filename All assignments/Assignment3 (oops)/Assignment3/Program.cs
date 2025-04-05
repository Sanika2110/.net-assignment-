using System;

interface IEmployee
{
    void DisplayEmployeeDetails();
}


class Employee : IEmployee
{

    protected string name;
    protected int employeeId;
    protected double salary;

    
    public Employee(string name, int employeeId, double salary)
    {
        this.name = name;
        this.employeeId = employeeId;
        this.salary = salary;
        Console.WriteLine(" Employee Constructor Called.");
    }

    private Employee()
    {
        Console.WriteLine(" Private Constructor Called.");
    }


    static Employee()
    {
        Console.WriteLine(" Static Constructor Called.");
    }


    public virtual void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Employee ID: {employeeId}, Name: {name}, Salary: {salary}");
    }


    public new void ShowInfo()
    {
        Console.WriteLine("Base Employee Class: ShowInfo() method.");
    }
}

class Manager : Employee
{
    private string department;

    public Manager(string name, int employeeId, double salary, string department)
        : base(name, employeeId, salary)
    {
        this.department = department;
        Console.WriteLine(" Manager Constructor Called.");
    }

    public override void DisplayEmployeeDetails()
    {
        Console.WriteLine($"Manager ID: {employeeId}, Name: {name}, Salary: {salary}, Department: {department}");
    }

    public new void ShowInfo()
    {
        Console.WriteLine(" Derived Manager Class: ShowInfo() method.");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("\n Creating an Employee Object...");
        Employee emp = new Employee("Alice", 101, 50000);
        emp.DisplayEmployeeDetails();
        emp.ShowInfo(); 

        Console.WriteLine("\nCreating a Manager Object...");
        Manager mgr = new Manager("Bob", 102, 70000, "IT");
        mgr.DisplayEmployeeDetails();
        mgr.ShowInfo();

        Console.WriteLine("\n Using Interface Reference...");
        IEmployee iEmp = mgr;
        iEmp.DisplayEmployeeDetails();

        Console.WriteLine("\n Program Executed Successfully!");
    }
}
