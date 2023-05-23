// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");
cardDir[] dirsTest1 = {
	cardDir.S, cardDir.S, cardDir.S, cardDir.S, cardDir.S, 
	cardDir.N, cardDir.N, cardDir.N, cardDir.N, cardDir.N };
walk t1 = new walk(dirsTest1);
Console.WriteLine(t1.isValid(10));
Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
Console.WriteLine(Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }));
Console.WriteLine(Kata.IsValidWalk(new string[] { "w" }));
Console.WriteLine(Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }));

//as a note some comments may act as journal entries. this is like a public programming journal.
public enum cardDir
{
	N,
	E,
	S,
	W
}

public class walk
{

	cardDir[] Dirs;
	public walk(cardDir[] dirs)
	{
		Dirs = dirs;
		//Dirs.Append()
	}

	public bool isValid(int reqLength) {
		if (Dirs.Length == reqLength)
		{
			Vector2 distance = Vector2.Zero;
			for(int i = 0; i < Dirs.Length; i++)
			{
				switch (Dirs[i])
				{
					case cardDir.N:
						distance.Y++;
						break;
					case cardDir.S:
						distance.Y--;
						break;
					case cardDir.E:
						distance.X--;
					
						break;
					case cardDir.W:
						distance.X++;
						
						break;
				}
			}
			if (distance == Vector2.Zero)
			{
				return true;
			}
		}

		return false;

	}

	
}

public class Kata
{
	public static bool IsValidWalk(string[] walk)
	{
		//insert brilliant code here
		//oops i forgot this extention was turned on lol 1626462354732576457652374532

		walk w = StrAtoWalk(walk);
		return w.isValid(10);
	}

	public static walk StrAtoWalk(string[] walk)
	{
		cardDir[] dirs = new cardDir[walk.Length];

		for (int i = 0; i < walk.Length; i++)
		{
			cardDir dirCurrent = 0;
			switch (walk[i])
			{
				case "n":
					// dirs.Append(cardDir.N);
					dirCurrent = cardDir.N;
					break;
				case "s":
					dirCurrent = cardDir.S;
					break;
				case "e":
					dirCurrent = cardDir.E;
					break;
				case "w":
					dirCurrent = cardDir.W;
					break;
			}

			//dirs.Append(dirCurrent);
			dirs[i] = dirCurrent;
		}
		return new walk(dirs);
	}


}