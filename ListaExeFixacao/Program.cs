using System;
using System.Globalization;
using ListaExeFixacao;

public class Pogram {
    public static void Main(string[] args) {
        Console.Write("How many employees will be registred? ");
        int qtyEmployees = int.Parse(Console.ReadLine());
        Employee employee;
        List<Employee> listEmployees = new List<Employee>();

        for(int i = 0; i < qtyEmployees; i++) {
            Console.WriteLine("Employee #1:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            listEmployees.Add(employee = new Employee(id, name, salary));
        }

        Console.Write("Enter the employee id that will have salary increase: ");
        int searchId = int.Parse(Console.ReadLine());

        Employee emp = listEmployees.Find(x => x.Id == searchId);
        if(emp != null) {
            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.IncreaseSalary(percentage);
        } else {
            Console.WriteLine("This id does not exist!");
        }

        Console.WriteLine("\nList of employees:");
        foreach(Employee objEmployee in listEmployees) {
            Console.WriteLine(objEmployee);
        }
    }
}