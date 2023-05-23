
using System;

var actual = new int[,]
	  {{1,2,3,6,7,8,8,1,2,5,6,65,3,3,2,231,2},
	   {1,2,2,2,3,54,3,32,54,1,21,2,2,2,5,2,16},
	   {2,3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
	  {1,2,2,2,3,54,3,32,54,1,21,2,2,2,5,2,16},
	  {1,2,3,6,7,8,8,1,2,5,6,65,3,3,2,231,2},
	  {1,2,2,2,3,54,3,32,54,1,21,2,2,2,5,2,16},
	   {2,3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2},
	  {1,2,2,2,3,54,3,32,54,1,21,2,2,2,5,2,16},
	  {2,3,2,2,2,2,2,2,2,2,2,2,2,2,2,2,2}};


var sol = Kata.FloodFill(actual, 0, 1, 4);

for (int i = 0; i < sol.GetLength(0); i++)
{
	for (int j = 0; j < sol.GetLength(1); j++)
	{
		Console.Write(sol[i, j] + " ");
	}
	Console.WriteLine();
}



public class Kata
{

	public static int[,] FloodFill(int[,] array, int y, int x, int newValue)
	{
		
		int oldVal = array[y, x];
		array[y, x] = newValue;
		if (y - 1 >= 0 && array[y - 1, x] == oldVal)
		{
			array = FloodFill(array, y - 1, x, newValue);
		}
		if (y + 1 < array.GetLength(0) && array[y + 1, x] == oldVal)
		{
			array = FloodFill(array, y + 1, x, newValue);
		}
		if (x - 1 >= 0 && array[y, x - 1] == oldVal)
		{
			array = FloodFill(array, y, x - 1, newValue);
		}
		if (x + 1 < array.GetLength(1) && array[y, x + 1] == oldVal)
		{
			array = FloodFill(array, y, x + 1, newValue);
		}
		return array;
	}






}

public class Vector2
{
	public int x;
	public int y;

	public Vector2(int Y,int X)
	{
		x = X;
		y = Y;
	}

}