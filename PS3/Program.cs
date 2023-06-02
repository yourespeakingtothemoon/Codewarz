// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(kyu5.sum_ann(150));

class kyu5
{
	public static void GenRefs(int n, ref int[] J, ref int[] A)
	{
		int[] JohnRef = new int[n];
		int[] AnnRef = new int[n];

		JohnRef[0] = 0;
		AnnRef[0] = 1;
		
		for (int i = 1; i < n; i++)
		{
			JohnRef[i] = i - AnnRef[JohnRef[i - 1]];
			AnnRef[i] = i - JohnRef[AnnRef[i - 1]];
		}
		J = JohnRef;
		A = AnnRef;

	}
	
	public static int[] john(int n)
	{
		int[] ret = new int[n];
		int[] JohnRef = new int[n];
		int[] AnnRef = new int[n];
		GenRefs(n,ref JohnRef, ref AnnRef);
	
		return JohnRef;
	}
	public static int[] ann(int n)
	{
		int[] ret = new int[n];
		int[] JohnRef = new int[n];
		int[] AnnRef = new int[n];
		GenRefs(n, ref JohnRef, ref AnnRef);

		return AnnRef;
	}

	public static int sum_john(int n)
	{
		int[] j = john(n);
		int ret = 0;
		for (int i = 0; i < j.Length; i++)
		{
			ret += j[i];
		}
		return ret;
	}
	public static int sum_ann(int n)
	{
		int[] a = ann(n);
		int ret = 0;
		for(int i=0;i< a.Length; i++)
		{
			ret += a[i];
		}
		return ret;
	}

	//public int[] J = new int[0];
	//public int[] A = new int[0];


}


//below is the code changed for the codewars because there is a discrepancy between the instructions and the actual test requirements

//using System;
//using System.Collections.Generic;

//public class Johnann
//{

//	public static List<long> John(long n)
//	{
//		List<long> ret = new List<long>();
//		long[] j = john(n);
//		for (int i = 0; i < j.Length; i++)
//		{
//			ret.Add(j[i]);
//		}

//		return ret;
//	}

//	public static List<long> Ann(long n)
//	{
//		List<long> ret = new List<long>();
//		long[] a = ann(n);
//		for (int i = 0; i < a.Length; i++)
//		{
//			ret.Add((long)a[i]);
//		}
//		return ret;
//	}

//	public static long SumJohn(long n)
//	{
//		return sum_john(n);
//	}
//	public static long SumAnn(long n)
//	{
//		return sum_ann(n);
//	}

//	public static void GenRefs(long n, ref long[] J, ref long[] A)
//	{
//		long[] JohnRef = new long[n];
//		long[] AnnRef = new long[n];

//		JohnRef[0] = 0;
//		AnnRef[0] = 1;

//		for (int i = 1; i < n; i++)
//		{
//			JohnRef[i] = i - AnnRef[JohnRef[i - 1]];
//			AnnRef[i] = i - JohnRef[AnnRef[i - 1]];
//		}
//		J = JohnRef;
//		A = AnnRef;

//	}

//	public static long[] john(long n)
//	{
//		long[] ret = new long[n];
//		long[] JohnRef = new long[n];
//		long[] AnnRef = new long[n];
//		GenRefs(n, ref JohnRef, ref AnnRef);

//		return JohnRef;
//	}
//	public static long[] ann(long n)
//	{
//		long[] ret = new long[n];
//		long[] JohnRef = new long[n];
//		long[] AnnRef = new long[n];
//		GenRefs(n, ref JohnRef, ref AnnRef);

//		return AnnRef;
//	}

//	public static long sum_john(long n)
//	{
//		long[] j = john(n);
//		long ret = 0;
//		for (int i = 0; i < j.Length; i++)
//		{
//			ret += j[i];
//		}
//		return ret;
//	}
//	public static long sum_ann(long n)
//	{
//		long[] a = ann(n);
//		long ret = 0;
//		for (int i = 0; i < a.Length; i++)
//		{
//			ret += a[i];
//		}
//		return ret;
//	}



//}

