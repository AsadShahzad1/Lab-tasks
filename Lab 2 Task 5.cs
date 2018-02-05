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
            int st, en, cnt = 0;

            Console.WriteLine("Starting Value:-");

            st = int.Parse(Console.ReadLine());

            Console.WriteLine("Ending Value:-");

            en = int.Parse(Console.ReadLine());



            for (int i = 1; i < en; i++)

            {

                for (int j = 1; j < en; j++)

                {

                    if (i % j == 0)

                    {

                        cnt++;

                    }

                }

                if (cnt == 2)

                {

                    Console.WriteLine(i);

                }

                cnt = 0;



            }


                Console.ReadLine();
        }



    }
}
