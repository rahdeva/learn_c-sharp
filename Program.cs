// See https://aka.ms/new-console-template for more information

// Hello World
Console.WriteLine("Hello, Deva!");

// String
string firstFriend = "Maria";
string secondFriend = "Mantap";
Console.WriteLine($"My friends are {firstFriend} & {secondFriend}");

string trimWord = "        Mantap      ";
Console.WriteLine($"Trim Start : {trimWord.TrimStart()}");
Console.WriteLine($"Trim End : {trimWord.TrimEnd()}");
Console.WriteLine($"Trim Start and End : {trimWord.Trim()}");

string myfriend = "Mantap";
Console.WriteLine($"Friend : {myfriend}");
myfriend = myfriend.Replace("Mantap", "Mintip");
Console.WriteLine($"NewFriend : {myfriend}");
myfriend = "Montop";
Console.WriteLine($"NewFriend : {myfriend}");

string randomString = "NiCe";
Console.WriteLine(randomString.ToUpper());
Console.WriteLine(randomString.ToLower());
Console.WriteLine(randomString.Length);
Console.WriteLine(randomString.StartsWith("N"));
Console.WriteLine(randomString.EndsWith("N"));

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings"));