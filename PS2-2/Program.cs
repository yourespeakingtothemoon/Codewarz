//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//int[] ints = { 10,2,3,3 };
//Console.WriteLine(Kata.QueueTime(ints, 2));
//int[] ints2 = {2,3,10};
//Console.WriteLine(Kata.QueueTime(ints2, 2));

////as a note some comments may act as journal entries. this is like a public programming journal.

////----------The Kata----------------
///*There is a queue for the self-checkout tills at the supermarket. Your task is write a function to calculate the total time required for all the customers to check out!
//input

//    customers: an array of positive integers representing the queue. Each integer represents a customer, and its value is the amount of time they require to check out.
//    n: a positive integer, the number of checkout tills.

//output

//The function should return an integer, the total time required.*/

//public class Kata
//{//copied from the codewars 
//	public static long QueueTime(int[] customers, int n)
//	{
//		//okay so I cant just add up the times and divide by the number of tills
//		//we have to account for the amount of time done
//		//Would it be fun and quirky to simulate each customer at each till?
		
//		//there a recursive way to do this?
//		//i dont think so

//		//List<int> tills = new List<int>();
//		int[] tills = new int[n];
//		for (int i = 0; i < n; i++)
//		{
//			tills[i] = 0;
//		}
//		//making a list of tills for this simulation
//		//now we need to simulate the customers
//		//I forgot codewars cant use c#lists
//		for (int x = 0; x < customers.Length; x++)
//		{
//			//make the shortest till
//			//then we loop through the tills to make sure its the shortest
//			//then add the next customer to the shortest till
//			//this seperates the times out so that 10 ends up in the first index and the rest end up in the second
//			int tillMin = 0;
//			for (int y = 0; y < tills.Length; y++)
//			{
//				if (tills[y] < tills[tillMin])
//				{
//					//lets use our first test example
//					//10,2,3,3
//					//till 0 is 0
//					//till 1 is 0
					
//					tillMin = y;
//				}
//			}
//			//add the customer to the shortest till
//			//this way back into the loop, it remains the "smaller time of till" 
//			//we add customer "x"'s time to the till's time
//			tills[tillMin] += customers[x];
//		}
//		//now we need to find the longest till
		
//		int tillMax=0;
//		for (int i = 0; i < tills.Length; i++)
//		{
//			//this then compares the two (or many) and outputs the one that has the most time attached to it.
//			if (tills[i] > tills[tillMax])
//			{
//				tillMax = i;
//			}
//		}
//		//simple as.
//		return tills[tillMax];

//	}
//}

