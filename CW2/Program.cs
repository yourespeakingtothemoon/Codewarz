// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



public class Kata
{
	public static int[] FoldArray(int[] array, int runs)
	{
		if (runs != 0)
		{
			int[] result;

			if (array.Length % 2 != 0)
			{
				result = new int[(array.Length / 2) + 1];
			}
			else
			{
				result = new int[array.Length / 2];
			}


			for (int i = 0; i < result.Length; i++)
			{
				result[i] = array[i] + array[array.Length - 1 - i];
			}
			if (array.Length % 2 == 1)
			{
				result[result.Length - 1] = array[array.Length / 2];
			}
			result = FoldArray(result, runs - 1);
			return result;
		}
		return array;
	}
}