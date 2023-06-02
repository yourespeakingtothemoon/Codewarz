// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//A friend of mine takes the sequence of all numbers from 1 to n (where n > 0).
//    Within that sequence, he chooses two numbers, a and b.
//    He says that the product of a and b should be equal to the sum of all numbers in the sequence, excluding a and b.
//    Given a number n, could you tell me the numbers he excluded from the sequence?

//The function takes the parameter: n(n is always strictly greater than 0) and returns an array or a string (depending on the language) of the form:

//[(a, b), ...] or[[a, b], ...] or
//{ { a, b}, ...}
//or or[{a, b}, ...]

//with all(a, b) which are the possible removed numbers in the sequence 1 to n.

//[(a, b), ...] or[[a, b], ...] or
//{ { a, b}, ...}
//or... will be sorted in increasing order of the "a".

//It happens that there are several possible (a, b). The function returns an empty array (or an empty string) if no possible numbers are found which will prove that my friend has not told the truth! (Go: in this case return nil).
//Examples:

//removNb(26) should return [(15, 21), (21, 15)]
//or
//removNb(26) should return { { 15, 21}, { 21, 15} }
//or
//removeNb(26) should return [[15, 21], [21, 15]]
//or
//removNb(26) should return [ { 15, 21}, { 21, 15} ]
//or
//removNb(26) should return "15 21, 21 15"

//or

//in C:
//removNb(26) should return  { { 15, 21} { 21, 15} }
//tested by way of strings.
//Function removNb should return a pointer to an allocated array of Pair pointers, each one also allocated. 

//Note

//See examples of returns for each language in "RUN SAMPLE TESTS"


public class RemovedNumbers
{
	public static List<long[]> removNb(long n)
	{
		List<long[]> ret = new List<long[]>();
		
		for(long i=0; i<=n; i++)
		{
			long j = (GetAndCheck(i, n));
			if (j > 0)
			{
				ret.Add(new long[] { i, j });
			}
		}
		return ret;
	}


	private static long SumOfSeq(long n)
	{
		return (n * (n + 1)) / 2;
	}
	private static long GetAndCheck(long i, long n)
	{
		long x = SumOfSeq(n) - i;
		long y = i + 1;
		long j = 0;
		if(x%y==0)
		{
			j = x / y;
		}
		if (j > 0 && j < n + 1)
		{
			return j;
		}
		return 0;
	}
	
	
}

