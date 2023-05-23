using System;

public class WeightSort
{

	public static string orderWeight(string strng)
	{
		// your code
		string[] nums = seperateStr(strng);
		BubbleSort(ref nums);
		strng = strBuild(nums);
		return strng;
	}

	public static string strBuild(string[] strs)
	{
		string result = "";
		for (int i = 0; i < strs.Length; i++)
		{
			result += strs[i];
			if (i < strs.Length - 1) { result += " "; }
		}
		return result;
	}

	public static int addTogether(string s)
	{
		int result = 0;
		for (int i = 0; i < s.Length; i++)
		{
			int num = 0;
			string temp = "";
			temp += s[i];
			num = int.Parse(temp);
			result += num;
		}
		return result;
	}



	public static void BubbleSort(ref string[] c)
	{
		int idx1, idx2;

		for (idx1 = 0; idx1 < c.Length - 1; idx1++)
		{
			for (idx2 = 0; idx2 < c.Length - idx1 - 1; idx2++)
			{
				if (addTogether(c[idx2]) > addTogether(c[idx2 + 1]))
				{
					SwapValues(ref c[idx2], ref c[idx2 + 1]);
				}
				if (addTogether(c[idx2]) == addTogether(c[idx2 + 1]))
				{
					if (c[idx2].CompareTo(c[idx2 + 1]) >= 0)
					{
						SwapValues(ref c[idx2], ref c[idx2 + 1]);

					}
				}
				/*  if (addTogether(c[idx2])==addTogether(c[idx2+1]))
                    {
                    if(c[idx2].Length>c[idx2+1].Length){
                        SwapValues(ref c[idx2], ref c[idx2 + 1]);
                      }
                    }*/
			}
		}

	}






	public static void SwapValues(ref string a, ref string b)
	{
		string temp = a;
		a = b;
		b = temp;
	}


	public static string[] seperateStr(string s)
	{
		string[] result;
		string[] big = new string[1000];
		string word = "";
		int wordCount = 0;
		for (int i = 0; i < s.Length; i++)
		{
			if (s[i] == ' ')
			{
				big[wordCount] = word;
				wordCount++;
				word = "";
				//wordCount++;
			}
			else
			{
				//wordCount++;
				word += s[i];
			}
		}
		if (word != "")
		{
			big[wordCount] = word;
		}

		result = new string[wordCount + 1];
		for (int i = 0; i < result.Length; i++)
		{
			result[i] = big[i];
		}
		return result;
	}




	public static void QuickSort(ref string[] c, int f, int cel)
	{
		if (f < cel)
		{
			Random rand = new Random();
			int pivotIndex = rand.Next(f, cel);
			SwapValues(ref c[pivotIndex], ref c[cel]);
			int part = QuickPart(ref c, f, cel);
			QuickSort(ref c, f, part - 1);
			QuickSort(ref c, part + 1, cel);
		}
	}

	private static int QuickPart(ref string[] c, int f, int cel)
	{
		string piv = c[cel];
		int idx = f - 1;

		for (int i = f; i < cel; i++)
		{
			if (addTogether(c[i]) <= addTogether(piv))
			{
				idx++;

				SwapValues(ref c[idx], ref c[i]);
			}

		}
		SwapValues(ref c[idx + 1], ref c[cel]);
		return idx + 1;
	}
}