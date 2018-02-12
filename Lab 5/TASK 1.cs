using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication15
{
    class information
    {
        string name;
        string location;
        int model;
        int speed;
        int weight;


        public information(string name, string location)
        {
            this.name = name;
            this.location = location;
            Console.WriteLine("Bicycle specificiation");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("location  " + location);
        }

        public information(string name, int model, int speed)
        {
            Console.WriteLine("Car specification");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("model  " + model);
            Console.WriteLine("speed  " + speed);
        }

        public information(string name, int model, int speed, int weight)
        {
            Console.WriteLine("lorry specification");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("model  " + model);
            Console.WriteLine("speed  " + speed);
            Console.WriteLine("weight " + weight);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*****************");
            information bicycle = new information("BMX", "Pakistan\n");
            Console.WriteLine("*****************");
            information car = new information("Ferrari", 9821, 1000);
            Console.WriteLine("*****************");
            information lorry = new information("Honda", 2314, 2313, 21312);
            Console.WriteLine("*****************");
            Console.ReadLine();

        }
    }
}