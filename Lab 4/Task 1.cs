
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee
    {
        public static int NumberOfEmployees;
        private static int counter;
        private string name;

        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    
        public static int Counter
        {
            get { return counter; }
        }

       
        public Employee()
        {
            
            counter = ++counter + NumberOfEmployees;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee.NumberOfEmployees = 107;
            Employee e1 = new Employee();
            e1.Name = "Claude Vige";

            System.Console.WriteLine("Employee number: {0}", Employee.Counter);
            System.Console.WriteLine("Employee name: {0}", e1.Name);
            Console.ReadLine();
        }
    }
}
