using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Application_in_C_
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Mobile { get; set; }
    }
         class Program
        {
            static List<Employee> employees = new List<Employee>();

            static void Main(string[] args)
            {
            while (true)
             {
                Console.WriteLine("CRUD Application");
                Console.WriteLine("----------------");
                Console.WriteLine("1.Create Employee");
                Console.WriteLine("2.Read Employee");
                Console.WriteLine("3.Update Employee");
                Console.WriteLine("4.Delete Employee");
                Console.WriteLine("5.Exit");
                Console.Write("Choose a option: ");
                int Option = Convert.ToInt32(Console.ReadLine());

                switch (Option)
                {
                    case 1: CreateEmployee(); break;
                    case 2: ReadEmployee(); break;
                    case 3: UpdateEmployee(); break;
                    case 4: DeleteEmployee(); break;
                    case 5: Environment.Exit(0); break;
                    default: Console.WriteLine("Invalid Option. Please Choose Valid Option.");break;
                }
             }
        }
        static void CreateEmployee()
        {
            Console.Write("\nEnter Employee Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Employee Department: ");
            string Department = Console.ReadLine();

            Employee employee = new Employee()
            {
                Id = employees.Count + 1,
                Name = name,
                Department = Department
            };
            employees.Add(employee);
            Console.WriteLine("Employee Created Successfuly!\n");
        }

        static void ReadEmployee()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No Employee Found");
            }
            else
            {
                Console.WriteLine("\nEmployees: ");
                foreach (Employee employee in employees)
                {
                    Console.WriteLine($"Id: {employee.Id}, \nName: {employee.Name},\nDepartment: {employee.Department}\n");
                }
            }         
        }
        static void UpdateEmployee()
        {
           Console.Write("\nEnter Employee Id: ");
           int id = Convert.ToInt32(Console.ReadLine());

           Employee employee = employees.Find(match:e => e.Id == id);

            if (employee != null)
            {
                Console.Write("Enter new employee Name: ");
                employee.Name = Console.ReadLine();
                Console.Write("Enter new Employee Department: ");
                employee.Department = Console.ReadLine();

                Console.WriteLine("Employee Updated Successfuly!\n");
            }
            else
            {
                Console.WriteLine("Employee Not Found!");
            }       
        }
        static void DeleteEmployee()
        {
            Console.Write("\nEnter Employee Id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Employee employee = employees.Find(e => e.Id == id);

            if (employee != null) 
            {
                employees.Remove(employee);
                Console.WriteLine("Employee Delete Successfully!\n");
            }
            else
            {
                Console.WriteLine("Employee not Found!");
            }
         }  
      }
   }

