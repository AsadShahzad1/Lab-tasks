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

            int op;
            int num1;
            int num2;
            double num3;
            long result;
            double fresult;
            Console.WriteLine("==========================Universal Calculator==================================\n");
            Console.WriteLine("1.Addition \t2.Subtraction \t 3.Multiplication \t 4.Division \t 5.Sin Cos tan");
            Console.Write("Select Operation: ");
            op = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n================================================================================\n");

            switch (op)
            {

                case 1:
                    Console.WriteLine("-ADDITION-\n");
                    Console.Write("Enter 1st Number: ");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter 2nd Number: ");
                    num2 = Int32.Parse(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine("Answer: {0}", result);

                    break;
                case 2:
                    Console.WriteLine("-SUBTRACTION-\n");
                    Console.Write("Enter 1st Number: ");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter 2nd Number: ");
                    num2 = Int32.Parse(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine("Answer: {0}", result);

                    break;

                case 3:
                    Console.WriteLine("-MULTIPLICATION \n-");
                    Console.Write("Enter 1st Number: ");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter 2nd Number: ");
                    num2 = Int32.Parse(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine("Answer: {0}", result);

                    break;
                case 4:
                    Console.WriteLine("-DIVISION-\n");
                    Console.Write("Enter 1st Number: ");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter 2nd Number: ");
                    num2 = Int32.Parse(Console.ReadLine());
                    fresult = num1 / num2;
                    Console.WriteLine("Answer: {0}", fresult);
                    break;
                case 5:
                    Console.WriteLine("-Trignometery Functions- \n");
                    Console.WriteLine("-Sin, Cos, Tan \n-");
                    Console.Write("Enter Angle ");
                    num3 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Sin :{0}",Math.Sin(num3));
                    Console.WriteLine("Cos :{0}",Math.Cos(num3));
                    Console.WriteLine("Tan :{0}",Math.Tan(num3));
                    break;
                case 6:
                    Console.WriteLine("-Power-\n");
                    Console.Write("Enter Base: ");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter Power: ");
                    num2 = Int32.Parse(Console.ReadLine());
                    fresult = Math.Pow(num1,num2);
                    Console.WriteLine("Answer: {0}", fresult);
                    break;
                case 7:
                    Console.WriteLine("-Division Remainder-\n");
                    Console.Write("Enter First Number: ");
                    num1 = Int32.Parse(Console.ReadLine());
                    Console.Write("\nEnter Second Number: ");
                    num2 = Int32.Parse(Console.ReadLine());
                    int newrest;
                    result = Math.DivRem(num1, num2, out newrest);
                    Console.WriteLine("Answer: {0}", result);
                    break;
                default:
                    break;

            }
            Console.ReadLine();
        }



    }
}
