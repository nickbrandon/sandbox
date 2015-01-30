using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStuff
{
    public class Employee4
    {
        public string id;
        public string name;

        //empty constructor
        public Employee4()
        {
        }

        //constructor with passed params
        public Employee4(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public static int employeeCounter;

        public static int AddEmployee()
        {
            return ++employeeCounter;
        }
    }

    class MainClass : Employee4
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the employee's name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the employee's ID: ");
            string id = Console.ReadLine();

            //Create and configure the employee object:
            Employee4 e = new Employee4(name, id);
            Console.WriteLine("Enter the current number of employees: ");
            string n = Console.ReadLine();
            Employee4.employeeCounter = Int32.Parse(n);
            Employee4.AddEmployee();

            //Display the new information:
            Console.WriteLine("Name: {0}", e.name);
        }
    }
}
