// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//morse m = new morse();
Console.WriteLine(morse.DecodeBits("1100110011001100000011000000111111001100111111001111110000000000000011001111110011111100111111000000110011001111110000001111110011001100000011"));


class morse
{
	public static string DecodeBits(string c)
	{
		string ret = "";
			int timeHeld = 0;
		if (c.Length % 2 != 0)
		{
			return "invalid string";
		}

		string[] divC = new string[c.Length / 2];
		for (int i = 0; i < divC.Length; i++)
		{
			int start = i * 2;

			divC[i] = c[start].ToString() + c[start + 1].ToString();

		}
			int timeReleased = 0;
		for (int i = 0; i < divC.Length; i++)
		{

			if (divC[i] == "11")
			{
				timeHeld += 1;
			}
			else if (divC[i] == "00")
			{
				if (timeHeld > 0)
				{
					ret += getMorseSym(timeHeld);
					timeReleased++;
				}
				else if (timeReleased > 0)
				{

					ret += getMorseSym(0);
					//timeHeld = 0;
					timeReleased = 0;
				}
				else
				{
					timeReleased++;
				}
				timeHeld = 0;
		}
			
			}
		if(timeHeld>0)
		{
			ret += getMorseSym(timeHeld);
			timeHeld = 0;
		}

		

		return ret;
	}

	public static char getMorseSym(int time)
	{
		switch (time)
		{
			case 1:
				return '.';
			case 3:
				return '-';
			default:
				return ' ';
		}
	}
}