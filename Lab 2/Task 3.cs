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
            long n, j;
            Console.Write("Enter number: ");
            n = long.Parse(Console.ReadLine());
            while (n > 0)
            {
                j = n % 10;
                Console.Write("{0}",j);
                n /= 10;
            }
            Console.ReadLine();
        }



    }
}
