using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    
        Employee employee = new Employee("Bob", 40, 23.77);
        
        // Console.WriteLine($"{employee.GetName()} is due: {employee.GetPay()}");

        ConstructionWorker constructionWorker = new ConstructionWorker("Alice", 40, 35.88);
        // Console.WriteLine($"{constructionWorker.GetName()} is due: {constructionWorker.GetPay()}");

        Doctor doctor = new Doctor("Belinda", 240000.99);
        // Console.WriteLine($"{doctor.GetName()} is due: {doctor.GetPay()}");

        List<employee> employees = new List<Employee>();
        employees.Add(employee):
        employees.Add(constructionWorker);
        employees.Add(doctor);

        foreach (Employee e in employees)
        {
            Console.WriteLine($"{e.GetName()} is due: {e.GetPay()}");
        }
    }


}