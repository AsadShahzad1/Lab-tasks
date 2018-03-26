
LAB # 7
Q.Create a class Vehicle 	
Class contains following data members: 
string model; 
string color; 
string engine; 
int door; 
constructors: 
Vehicle(), 
Vehicle(string, string, string, string,int), 
and function: 
void start(); 
void stop(); 
void run(); 
virtual void calculateSpeed()=0; 
void printInfo(); 
Inherite car and bike class from the vehicle class and override the virtual method calculateSpeed() in 
both classes

CODING:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_7
{
    class vechile
    {
        public string model;
        public string color;
        public string engine;
        public int door;
        public vechile()
        {

        }
        public vechile(string a, string b, string c, string d)
        {

        }
        public void start()
        {

        }
        public void stop()
        {

        }
        public void run()
        {

        }
        public virtual void calculateSpeed()
        {
            double d,s,t;
            Console.WriteLine("Enter time to taken travel");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter distance");
            d = Convert.ToDouble(Console.ReadLine());
            s = d / t;
            Console.WriteLine("The speed is"+s);


        }
        public void printinfo()
        {
           
        }
    }
    class car:vechile
    {
        public override void calculateSpeed()
        {
            double d, s, t;
            Console.WriteLine("============CAR SPEED===========");
            Console.WriteLine("Enter time to taken travel from car in seconds");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter completed distance of car in meters");
            d = Convert.ToDouble(Console.ReadLine());
            s = d / t;
            Console.WriteLine("The speed of car is " + s +" m/s");
        }
    }
    class bike:vechile
    {
        public override void calculateSpeed()
        {
            double d, s, t;
            Console.WriteLine("============BIKE SPEED=============");
            Console.WriteLine("Enter time to taken travel from bike in seconds");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter completed distance of bike in meters");
            d = Convert.ToDouble(Console.ReadLine());
            s = d / t;
            Console.WriteLine("The speed of bike is " + s + " m/s");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            vechile obj1 = new car();
            vechile obj2 = new bike();
            obj1.calculateSpeed();
            obj2.calculateSpeed();
            Console.ReadKey();
        }
    }
}
