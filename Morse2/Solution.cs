//class MorseCodeDecoder
//{
//	MorseCodeDecoder(string c, bool binary = true)
//	{
//		if (binary)
//		{
//		}
//		else
//		{
//			code = c;
//		}
//	}
//	string decode()
//	{
//		string ret = "";
//		string c = "";
//		for (int i = 0; i < code.Length; i++)
//		{
//			if (code[i] == ' ')
//			{
//				if (i - 1 > 0 && i + 1 < code.Length && code[i - 1] == ' ' && code[i + 1] == ' ')
//				{
//					ret += " ";
//				}
//				else
//				{
//					string a = MorseCode.Get(c);
//					ret += a;
//				}

//				c = "";
//			}
//			else
//			{
//				c += code[i];
//			}

//		}

//		if (c != "")
//		{
//			ret += MorseCode.Get(c);
//		}

//		return ret;
//	}

//	char getChar(string morse)
//	{
//		//read val list to determine which character A-Z, ! and SOS code
//		//using . and -
//		switch (morse)
//		{

//			case ".-":
//				return 'A';
//			case "-...":
//				return 'B';
//			case "-.-.":
//				return 'C';
//			case "-..":
//				return 'D';
//			case ".":
//				return 'E';
//			case "..-.":
//				return 'F';
//			case "--.":
//				return 'G';
//			case "....":
//				return 'H';
//			case "..":
//				return 'I';
//			case ".---":
//				return 'J';
//			case "-.-":
//				return 'K';
//			case ".-..":
//				return 'L';
//			case "--":
//				return 'M';
//			case "-.":
//				return 'N';
//			case "---":
//				return 'O';
//			case ".--.":
//				return 'P';
//			case "--.-":
//				return 'Q';
//			case ".-.":
//				return 'R';
//			case "...":
//				return 'S';
//			case "-":
//				return 'T';
//			case "..-":
//				return 'U';
//			case "...-":
//				return 'V';
//			case ".--":
//				return 'W';
//			case "-..-":
//				return 'X';
//			case "-.--":
//				return 'Y';
//			case "--..":
//				return 'Z';

//			//NUMBERSSSSSSSSS

//			case "-----":
//				return '0';
//			case ".----":
//				return '1';
//			case "..---":
//				return '2';
//			case "...--":
//				return '3';
//			case "....-":
//				return '4';
//			case ".....":
//				return '5';
//			case "-....":
//				return '6';
//			case "--...":
//				return '7';
//			case "---..":
//				return '8';
//			case "----.":
//				return '9';

//			//Symbol(s)
//			case "-.-.--":
//				return '!';
//			case ".−.−.−":
//				return '.';
//			//SOS Code read
//			case "...---...":
//				return ';';
//			//semicolons are not in international standard and I wont return a string

//			// case " ":
//			//return '';
//			default:
//				return '#';
//		}
//	}

//	public static string Decode(string morseCode)
//	{
//		MorseCodeDecoder m = new MorseCodeDecoder(morseCode, false);

//		return m.decode().TrimStart();
//	}

//	public string code = "";
//}