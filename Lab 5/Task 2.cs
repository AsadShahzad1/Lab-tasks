using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Complex
    {
        double real, img;

        public Complex(double real, double img)
        {
            this.real = real;
            this.img = img;
        }
        public Complex()
        {
            real = 5;
            img = 7;

        }

        public void display()
        {
            Console.WriteLine("Complex Number is : {0}+{1}i", real, img);
        }

        public void mag()
        {
            double x;
            x = Math.Sqrt(real * real + img * img);
            Console.WriteLine("Magnitude of First complex Number is :{0}", x);
        }


        public static Complex operator +(Complex c1, Complex c2)///addition
        {
            return new Complex(c1.real + c2.real, c1.img + c2.img);
        }



        public override string ToString()
        {
            return string.Format("{0} + {1}i", real, img);
        }

    }
    class program
    {
        static void Main(string[] args)
        {

            double e, r;
            Complex c3 = new Complex();
            c3.display();
            c3.mag();

            Console.WriteLine("Enter Second Complex Number its real and imagenary parts");
            r = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            Complex c1 = new Complex();
            Complex c2 = new Complex(r, e);

            Complex sum = c1 + c2;
            Console.WriteLine("The sum of  two complex number is : {0}", sum);

            Console.ReadLine(); // Pause
        }
    }
}