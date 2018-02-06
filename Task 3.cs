using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class checkvowel {
        int total = 0;
        public void input(String name) {
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                {
                    total++;
                }
            }   
         
        }
        public int printValue() {

            return total;
        
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
           string nam;
            checkvowel ch = new checkvowel();
            Console.Write("Enter Name: ");
            nam = Console.ReadLine();
            ch.input(nam);
            Console.WriteLine("\nNumber of Vowels are: {0}", ch.printValue());
            Console.ReadLine();
        }
    }
}
