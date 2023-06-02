// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MorseCodeDecoder d = new MorseCodeDecoder();

string bcode = "110011001100110000001100000011111100110011111100111111000000000000001100111111001111110011111100000011001100111111000000111111001100110000001100";
Console.WriteLine(bcode.Length);
Console.WriteLine(d.decodeBits(bcode));