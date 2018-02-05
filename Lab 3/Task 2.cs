using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class student
    {
        public double phy, che, ca, total;
        public double per;
        public string nm, div;

        
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.nm = "Asad Shahzad";
            s.phy = 50;
            s.che = 60;
            s.ca = 40;      
            s.total = s.phy + s.che + s.ca;
            s.per = s.total / 3.0;
            if (s.per >= 60)
                s.div = "First";
            else
            if (s.per < 60 && s.per >= 48)
                s.div = "Second";
            else
                if (s.per < 48 && s.per >= 36)
                s.div = "Pass";
            else
                s.div = "Fail";

            Console.Write("\nName of Student : {0}\n",s.nm);
            Console.Write("Marks in Math : {0}\nMarks in English : {1}\nMarks in Science : {2}\n", s.phy, s.che, s.ca);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", s.total, s.per, s.div);



            Console.ReadLine();
        }



    }
}
