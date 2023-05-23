using System;

Console.WriteLine(Packer.PackBagpack(new int[] { 15, 10, 9, 5 }, new int[] { 1, 5, 3, 4 }, 8));



public class Packer
{
	public static int PackBagpack(int[] scores, int[] weights, int capacity)
	{
		BubbleSort(ref scores, ref weights);
		
		return Pack(scores,weights,capacity);


		int[,] ary = new int[10, 10];

		ary.Length;

	}

	public static int Pack(int[] scores, int[] weights, int capacity)
	{
		int cap = capacity;
		int score = 0;
		int i = 0;
		while (cap > 0 && i < scores.Length)
		{
			if (weights[i] < cap)
			{
				if (checkCap(cap - weights[i], weights, i) || cap != 0)
				{
					score += scores[i];
					cap -= weights[i];
				}
			}
			i++;
		}
		if (cap > 0)
		{
			BubbleSort(ref weights, ref scores);
			SwapValues(ref weights[0], ref weights[weights.Length - 1]);
			SwapValues(ref scores[0], ref weights[scores.Length - 1]);
			score = Pack(scores, weights, capacity);
		}
		return score;
	}

	public static bool checkCap(int proposedCap, int[] weights, int startIdx)
	{
		for (int i = startIdx; i < weights.Length; i++)
		{
			if (weights[i] < proposedCap)
			{
				return true;
			}
		}
		return false;
	}
	public static void SwapValues(ref int a, ref int b)
	{
		int temp = a;
		a = b;
		b = temp;
	}

	public static void BubbleSort(ref int[] c, ref int[] c2)
	{
		int idx1, idx2;

		for (idx1 = 0; idx1 < c.Length - 1; idx1++)
		{
			for (idx2 = 0; idx2 < c.Length - idx1 - 1; idx2++)
			{
				if (c[idx2] < c[idx2 + 1])
				{
					SwapValues(ref c[idx2], ref c[idx2 + 1]);
				}
			}
		}

	}
}






