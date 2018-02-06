
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Vehicle
    {
        private string name;
        private string color;
        private string company;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color=value;
            }
        }
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company=value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Name = "CD70";
            v.Color = "Black";
            v.Company = "Unique";
            Console.WriteLine("Name: {0}",v.Name);
            Console.WriteLine("Color: {0}", v.Color);
            Console.WriteLine("Company: {0}", v.Company);
            Console.ReadLine();   
        }
    }
}
