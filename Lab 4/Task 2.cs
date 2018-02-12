        using System;
        using System.Collections.Generic;
        using System.Linq;
        using System.Text;
        using System.Threading.Tasks;

        namespace ConsoleApplication1
        {

            public static class Factor
            {
                public static long FactorialUsingFor(this long factorialNumber)
                {
                    int product = 1;
                    for (int i = 1; i <= factorialNumber; i++)
                    {
                        product = product * i;

                    }
                    return product;
                }
            }
            class Program
            {
                static void Main(string[] args)
                {
                    long number = 5;
        long result = number.FactorialUsingFor();
        Console.WriteLine(result);
           
                    Console.ReadLine();
                }
            }
                }
