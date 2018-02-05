using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {

            double radius, diameter, circum, area, pi = 3.14;
             
            Console.Write("Please Enter the Radius: ");
            radius = Double.Parse(Console.ReadLine());
            diameter= radius * radius;
            circum= 2*pi*radius;
            area = 2*pi*(radius * radius);
            Console.WriteLine("\nThe Diameter is {0}.", diameter);
            Console.WriteLine("\nThe Circumference is {0}.", circum);
            Console.WriteLine("\nThe Area is {0}.", area);
           

            Console.ReadLine();
        }
      
    }
        
 

}
