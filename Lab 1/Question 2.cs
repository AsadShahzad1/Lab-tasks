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
            string letter;
            Console.Write("Enter Letter: ");
            letter = Console.ReadLine();
            if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
            {
                Console.WriteLine("Letter is vowel");
            }
            else
            {
                Console.WriteLine("Letter is not vowel");
            }
            
            Console.ReadLine();
        }



    }
}
