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
            int n = 0;
            
            while (n != -1) {
                Console.WriteLine("1.Cofee \t 2.Tea \t 3.coke \t 4. Orange Juice \t \t Enter -1 to Exit");
                Console.Write("Enter your Choice: ");
                n= Int32.Parse(Console.ReadLine());
                if(n > 4)
                {
                    Console.WriteLine("\nInvalid selection\n");
                }
                if(n== -1)
                {
                    System.Environment.Exit(1);
                }
            }
            Console.ReadLine();
        }



    }
}
