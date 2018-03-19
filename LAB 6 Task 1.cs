//LAB 6 TASK 1:

Class Account{

 public double accountBalance;
 
 public int credit(int c_amount){
 	
	accountBalance = accountBalance+c_amount; 

}
 public int debit(int d_amount){
 	
	if(d_amount < accountBalance){
	accountBalance= accountBalance-d_amount;}
	else{
		Console.WriteLine("Debit amount exceeded Account balance");
	}
}
public void getBalance(){

	Console.WriteLine("Current Balance: "+accountBalance);
}

}

class SavingsAccount : Account{

public double interestrate;
public void Interest(double interest){

	
	
	interestrate = interest*accountBalance;
	
}
		

}
Class CheckingAccount : Account {

double feecharged;

public void credit(fee)
{
feecharger = fee;
Console.WriteLine("Enter the amount to add\n");
int add;
add=Int32.Parse(Console.ReadLine());
accountBalance=accountBalance+add;
accountBalance=accountBalance-feecharger;
Console.WriteLine("Fee deducted\n");
}
public void void debit()
{
Console.WriteLine("Enter the amount to withdraw\n");
int get;
get=Int32.Parse(Console.ReadLine());
if(get > accountBalance)
{
accountBalance=accountBalance-get;
accountBalance=accountBalance-feecharger;
Console.WriteLine("Fee deducted\n");
}
else
Console.WriteLine("Debit amount exceeded account balance\n");
}

}

