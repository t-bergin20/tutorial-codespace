using System.Security.AccessControl;

Console.WriteLine("Hello, World!");

string aFriend = "Bill";
Console.WriteLine($"Hello, {aFriend}.");

aFriend = "Maira";
Console.WriteLine($"Hello, {aFriend}.");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}.");

Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

string greeting = "      Hello World!       ";
Console.WriteLine($"[{greeting}]");
Console.WriteLine($"[{greeting.TrimStart()}]");
Console.WriteLine($"[{greeting.TrimEnd()}]");
Console.WriteLine($"[{greeting.Trim()}]");
Console.WriteLine(greeting);

string sayHello = "Hello World!"; 
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");
Console.WriteLine(sayHello);
Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());

string songLyric = "You say goodbye, and I say hello";
Console.WriteLine(songLyric.Contains("goodbye"));
Console.WriteLine(songLyric.Contains("farewell"));
Console.WriteLine(songLyric.StartsWith("You"));
Console.WriteLine(songLyric.StartsWith("goodbye"));
Console.WriteLine(songLyric.EndsWith("You"));
Console.WriteLine(songLyric.EndsWith("goodbye."));




