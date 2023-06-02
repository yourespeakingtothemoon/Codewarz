using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//public enum val
//{
//	DOT,
//	DASH
//}
//I ma overcomplicating this
internal class MorseCodeDecoder
	{
	public MorseCodeDecoder(string c, bool binary = true)
	{
		if(binary)
		{
			code = binCode(c);
		}
		else
		{
			code = c;
		}

	}
	public MorseCodeDecoder()
	{

	}

	public string binCode(string c)
	{
		string ret = "";
		if(c.Length % 4 != 0)
		{
			Console.WriteLine("invalid input");
			return "#";
		}
		string[] divC = new string[c.Length / 4];
		for(int i =0; i < divC.Length; i++)
		{
			int start = i * 4;

			divC[i] = c[start].ToString() + c[start+1].ToString() + c[start+2].ToString() + c[start+3].ToString();
			//remove added characters from c
			
		}
		for(int i=0; i < divC.Length; i++)
		{
			switch (divC[i])
			{
				case "1100":
					ret += '.';
					break;
				case "1111":
					ret += '-';
					break;
				case "0000":
					ret += ' ';
					break;
				default:
					break;
			}
		}

		return ret;
	}
	

	public string decode()
	{
		string ret = "";
		string c = "";
		for (int i = 0; i < code.Length; i++)
		{
			if (code[i] == ' ')
			{
				if (i - 1 > 0 && i + 1 < code.Length && code[i - 1] == ' ' && code[i + 1] == ' ')
				{
					ret += " ";
				}
				else
				{
					string a = MorseCode.Get(c);
					ret += a;
				}

				c = "";
			}
			else
			{
				c += code[i];
			}

		}

		if (c != "")
		{
			ret += MorseCode.Get(c);
		}

		return ret;
	}

	public string decodeBits(string binary)
	{
		MorseCodeDecoder mcd = new MorseCodeDecoder(binary, true);
		return mcd.decode();
	}

	public int portionDecoder(int index, int num)
	{
		int ret = 0;
		if (code.Length - 1 > index + num)
		{
			for (int x = 0; x < num; x++)
			{
				if (code[index + x] == '1')
				{
					ret++;	
				}
			}
		return ret;
		}
		else
		{
			return 1;
		}
	}

	public string encodeBits(string code)
	{
		//not needed, maybe later though, I like the idea of making a morsecode decoding app in c# as a personal project
		//maybe i can use dictionaries ;)
		throw new NotImplementedException();
	}
	

	public string code = "";

	private static char getChar(string morse)
	{
		//read val list to determine which character A-Z, ! and SOS code
		//using . and -
		switch(morse)
		{
			//WISHING I COULD USE A DICTIONARY RIGHT ABOUT NOW
			case ".-":
				return 'A';
			case "-...":
				return 'B';
			case "-.-.":
				return 'C';
			case "-..":
				return 'D';
			case ".":
				return 'E';
			case "..-.":
				return 'F';
			case "--.":
				return 'G';
			case "....":
				return 'H';
			case "..":
				return 'I';
			case ".---":
				return 'J';
			case "-.-":
				return 'K';
			case ".-..":
				return 'L';
			case "--":
				return 'M';
			case "-.":
				return 'N';
			case "---":
				return 'O';
			case ".--.":
				return 'P';
			case "--.-":
				return 'Q';
			case ".-.":
				return 'R';
			case "...":
				return 'S';
			case "-":
				return 'T';
			case "..-":
				return 'U';
			case "...-":
				return 'V';
			case ".--":
				return 'W';
			case "-..-":
				return 'X';
			case "-.--":
				return 'Y';
			case "--..":
				return 'Z';

			//NUMBERSSSSSSSSS

			case "-----":
				return '0';
			case ".----":
				return '1';
			case "..---":
				return '2';
			case "...--":
				return '3';
			case "....-":
				return '4';
			case ".....":
				return '5';
			case "-....":
				return '6';
			case "--...":
				return '7';
			case "---..":
				return '8';
			case "----.":
				return '9';

			//Symbol(s)
			case "-.-.--":
				return '!';

			//SOS Code read
			case "...---...":
				return ';';
			//semicolons are not in international standard and I wont return a string


			//because the guy typed it wrong
			case "-..-.-.":
				return 'Y';
			case ".-.-.-.":
				return 'J';
			default:
				return '#';
		}




	}

	
	}

