using System;
class PrimeNum
{
	public static void Main(String [] args)
	{

		int number;
		int flag=1;
		Console.WriteLine("Enter a number");
		number=Convert.ToInt32(Console.ReadLine());
		
		for(int i=2;i<=number/2;i++){
			if(number%i==0){
		          flag=0;
			  break;
		}
	    }
		if(flag==0){
		   Console.WriteLine("The number "+number+" is not a prime number");
	}
		else{
		   Console.WriteLine("The number "+number+" is a prime number");
	}
    }
}