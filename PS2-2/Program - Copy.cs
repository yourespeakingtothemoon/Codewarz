// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] ints = { 10,2,3,3 };
Console.WriteLine(Kata.QueueTime(ints, 2));
int[] ints2 = {2,3,10};
Console.WriteLine(Kata.QueueTime(ints2, 2));

//as a note some comments may act as journal entries. this is like a public programming journal.

//----------The Kata----------------
/*There is a queue for the self-checkout tills at the supermarket. Your task is write a function to calculate the total time required for all the customers to check out!
input

    customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.
    n: a positive integer, the number of checkout tills.

output

The function should return an integer, the total time required.*/

public class Kata
{
	public static long QueueTime(int[] customers, int n)
	{
	

		
		int[] tills = new int[n];
		for (int i = 0; i < n; i++)
		{
			tills[i] = 0;
		}
		
		for (int x = 0; x < customers.Length; x++)
		{
			
			int tillMin = 0;
			for (int y = 0; y < tills.Length; y++)
			{
				if (tills[y] < tills[tillMin])
				{
					
					
					tillMin = y;
				}
			}
		
			tills[tillMin] += customers[x];
		}
		
		
		int tillMax=0;
		for (int i = 0; i < tills.Length; i++)
		{
			
			if (tills[i] > tills[tillMax])
			{
				tillMax = i;
			}
		}
		//simple as.
		return tills[tillMax];

	}
}

