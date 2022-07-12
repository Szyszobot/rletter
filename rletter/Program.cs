string chars = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ";
Random rand = new Random();
int letter = rand.Next(0, chars.Length);
Console.WriteLine(chars[letter]);

string str = Char.ToString(chars[letter]);
File.WriteAllText(@"C:\Users\jedrzej.szyszka\Desktop\Results\randomletter.txt", str);
