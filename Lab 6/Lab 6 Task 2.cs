using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   
    class AddMarks{

  public int[] marks= new int[5];
	
   public void Marks(){
	Console.Write("\nEnter Subject Marks");
	Console.Write("\nEnter Subject 1 Marks: ");
	marks[0]=Int32.Parse(Console.ReadLine());
	Console.Write("\nEnter Subject 2 Marks: ");
	marks[1]=Int32.Parse(Console.ReadLine());
	Console.Write("\nEnter Subject 3 Marks: ");
	marks[2]=Int32.Parse(Console.ReadLine());
	Console.Write("\nEnter Subject 4 Marks: ");
	marks[3]=Int32.Parse(Console.ReadLine());
	Console.Write("\nEnter Subject 5 Marks: ");
	marks[4]=Int32.Parse(Console.ReadLine());

}	

}
class TotalMarks:AddMarks{

  public int total;
	public void totalMarks(){

        total = marks[0] + marks[1] + marks[2] + marks[3] + marks[4];
}

}
class Percentage:TotalMarks{


	public float per;
 	public void CalPer(){
        per = total / 5;
}



}
class display : Percentage {

    public String DepName;
    public String name;
    public void Display() {
        Console.WriteLine("Department Name: "+DepName);
        Console.WriteLine("Student Name: "+name);
        Console.WriteLine("Percentage:{0}%",per);
    }

}

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Generate a marksheet of different departments with proper record and calculate percentage with average of different subjects using Multilevel inheritance.\n");
            display d = new display();
            Console.Write("\nEnter Department Name: ");
            d.DepName = Console.ReadLine();
            Console.Write("\nEnter Student Name: ");
            d.name = Console.ReadLine();
            d.Marks();
            d.totalMarks();
            d.CalPer();
            d.Display();
            Console.ReadLine();
        }
    }
}
